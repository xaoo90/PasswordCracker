using Shared;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace LHWcfServiceLibrary
{
    public sealed class Manager
    {
        private static Manager instance;
        private static readonly object m_oPadLock = new object();
        private static readonly object SyncObject = new object();
        private List<ILHServiceCallback> clients = new List<ILHServiceCallback>();
        private ILHServiceCallback GUI;
        private Package package;
        private BigInteger actual = 1;
        private bool stopFlag = false;
        private Dictionary<BigInteger, DateTime> sentPackages = new Dictionary<BigInteger, DateTime>();
        private double processingTime;
        private int sentPackageCount = 0;
        private DateTime timeStarted;
        private List<ILHServiceCallback> inactiveClients = new List<ILHServiceCallback>();
        private string dictionaryPath;
        MD5Hash md5hash = new MD5Hash();

        public DateTime getTimeStarted()
        {
            return timeStarted;
        }

        public string getDictionaryPath()
        {
            return dictionaryPath;
        }

        internal void resetStopFlag()
        {
            stopFlag = false;
        }

        public void setStopFlag()
        {
            stopFlag = true;
        }

        public int getClientCount()
        {
            return clients.Count;
        }
        public void sendNextPackageToClient(ILHServiceCallback call, BigInteger firstIndex)
        {
            lock (SyncObject)
            {
                if (!stopFlag)
                {
                    sentPackages.Remove(firstIndex);

                    bool packageSent = false;

                    double avgTime = processingTime / sentPackageCount;

                    foreach (var item in sentPackages)
                    {
                        if (DateTime.Now.Subtract(item.Value).TotalSeconds > avgTime * 4)
                        {
                            this.getPackage().setFirstIndex(item.Key);
                            sentPackages[item.Key] = DateTime.Now;
                            packageSent = true;
                            Console.WriteLine("Retransmisja paczki "  + item.Key);
                            break;
                        }
                    }

                    if (!packageSent)
                    {
                        this.getPackage().setFirstIndex(actual);
                        sentPackages.Add(actual, DateTime.Now);
                        Console.WriteLine("!packageSent " + actual);
                        actual += this.getPackage().getSizePackage();
                    }
                    //Console.WriteLine("sendNextPackageToClient " + actual);
                    call.getPackageCallback(this.getPackage());
                }
            }
        }

        public void sentFirstPackagesToClients()
        {
            if (!stopFlag)
            {
                timeStarted = DateTime.Now;
                foreach (var call in clients)
                {
                    this.getPackage().setFirstIndex(actual);
                    Task.Run(() =>
                    {
                        try
                        {
                            call.getPackageCallback(this.getPackage());
                        }
                        catch (TimeoutException)
                        {
                            inactiveClients.Add(call);
                            Console.WriteLine("remove Client");
                        }
                    });

                    Console.WriteLine("sentFirstPackagesToClients " + actual);
                    DateTime time = DateTime.Now;
                    sentPackages.Add(actual, time);
                    actual += this.getPackage().getSizePackage();
                }
            }
        }

        public void incrementPackageCount(double processingTime)
        {
            if (!stopFlag)
            {
                this.sentPackageCount++;
                this.processingTime += processingTime;
                GUI.nowyCzas(processingTime);
                //Console.WriteLine("time newCzas() " + processingTime);
            }
        }

        public void addClient(ILHServiceCallback client)
        {
            this.clients.Add(client);

        }

        public void addClientSerw(ILHServiceCallback GUI)
        {
            this.GUI = GUI;
        }

        private Manager()
        {

        }

        public static Manager Instance()
        {
            Manager result;
            lock (Manager.m_oPadLock)
            {
                if (Manager.instance == null)
                {
                    Manager.instance = new Manager();
                }
                result = Manager.instance;
            }
            return result;
        }

        public void setPackage(Package package)
        {
            reset();
            this.dictionaryPath = package.getDictionaryFileCheckSum();
            if(package.getMethod() == 1)
                package.setDictionaryFileCheckSum(md5hash.getMd5CheckSum(dictionaryPath));
            this.package = package;
            this.actual = package.getFirstIndex();

            foreach (ILHServiceCallback inactiveClient in inactiveClients)
            {
                Console.WriteLine("delete client");
                clients.Remove(inactiveClient);
            }
        }

        private void reset()
        {
            this.sentPackages.Clear();
            this.sentPackageCount = 0;
            this.processingTime = 0;
        }

        public Package getPackage()
        {
            return this.package;
        }

        public void sendResultToGUI(Result result)
        {

            //passwordFoundFlag = true;

            GUI.getClientsCounter(clients.Count);
            GUI.showResult(result);
            //actual = 1;
            //sentPackages.Clear();

        }

        public void removeCrackedPasswordFromPackage(string hashedPassword)
        {
            //Console.WriteLine("-------------removeCrackedPasswordsFromPackage " + hashedPassword);
            //Console.WriteLine("przed  " + paczka.getPasswordsToCrack().Count);
            this.package.getPasswordsToCrack().Remove((hashedPassword));
            if (package.getPasswordsToCrack().Count == 0)
            {
                stopFlag = true;
                double avgTime = processingTime / sentPackageCount;
                GUI.activateBtStartWhenAllPasswordsFound(avgTime);
            }
            //Console.WriteLine("po  " + paczka.getPasswordsToCrack().Count);
        }
    }
}
