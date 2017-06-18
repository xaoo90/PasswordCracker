using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Shared;
using System.Threading;
using System.Numerics;
using System.IO;

namespace LHWcfServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class LHService : ILHService
    {
        Manager manager = Manager.Instance();
        MD5Hash md5hash = new MD5Hash();
        private double processingTime;
        private int clientCount = 0;

        public void setPackage(Package package)
        {
            manager.resetStopFlag();
            manager.setPackage(package);
            manager.addClientSerw(this.Callback);
            manager.sentFirstPackagesToClients();
            this.processingTime = 0;
        }

        public void addClient()
        {
            manager.addClient(this.Callback);
            Console.WriteLine("add Client " + ++clientCount);
        }

        ILHServiceCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<ILHServiceCallback>();
            }
        }


        public void stop()
        {
            manager.setStopFlag();
        }


        public void sendDictionary()
        {
            Console.WriteLine("sendDictionary");
            string ditionaryName = Path.GetFileName(manager.getDictionaryPath());
            this.Callback.setDictionaryName(ditionaryName);
            partiallySendDictionary(this.Callback);
            manager.sendNextPackageToClient(this.Callback, 0);
        }

        int count = 0;

        private void partiallySendDictionary(ILHServiceCallback client)
        {
            FileStream fs = new FileStream(manager.getDictionaryPath(), FileMode.Open, FileAccess.Read);
            int bytesRead = 0;
            var bytes = new byte[16384];

            while ((bytesRead = fs.Read(bytes, 0, 16384)) > 0)
            {

                client.appendDictionaryPart(bytes, 0, bytesRead);
                Console.WriteLine(++count);
            }
            fs.Close();
            fs.Dispose();
        }

        public void nextPackage(ClientResponse clientResponse)
        {
            manager.incrementPackageCount(clientResponse.getProcessingTime());
            processingTime += clientResponse.getProcessingTime();
            foreach (var item in clientResponse.getCrackedPasswords())
            {
                Result result = new Result();
                string passwordHash = md5hash.getMd5Hash(item.Key);
                result.setHash(passwordHash);
                result.setPassword(item.Key);
                result.setProcessingTime(DateTime.Now.Subtract(manager.getTimeStarted()).TotalSeconds);
                manager.sendResultToGUI(result);
                manager.removeCrackedPasswordFromPackage(passwordHash);
            }
            manager.sendNextPackageToClient(this.Callback, clientResponse.getPackageIndex());
        }

        public void sendResponseWhenAllPasswordsFound(ClientResponse clientResponse)
        {
            processingTime += clientResponse.getProcessingTime();
            foreach (var item in clientResponse.getCrackedPasswords())
            {
//                Console.WriteLine("czas dla hasla" + item.Value);
                Result result = new Result();
                string passwordHash = md5hash.getMd5Hash(item.Key);
                result.setHash(passwordHash);
                result.setPassword(item.Key);
                result.setProcessingTime(DateTime.Now.Subtract(manager.getTimeStarted()).TotalSeconds);
                manager.sendResultToGUI(result);

                manager.removeCrackedPasswordFromPackage(passwordHash);
            }
        }
    }
}
