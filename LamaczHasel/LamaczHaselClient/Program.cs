using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LamaczHaselClient.LHServiceRef;
using Shared;

namespace LamaczHaselClient
{
    public class CallbackHandler : ILHServiceCallback
    {
        private Package package;
        private LHServiceClient host;
        private ICrackPassword go;
        private int passwordsToCrackCount;
        private string path = @"slownik\\";
        //string fileName = "";
        private string dictionaryName = "polski.txt";
        MD5Hash md5Hash = new MD5Hash();

        public void setClient(LHServiceClient client)
        {
            this.host = client;
        }

        public void getPackageCallback(Package package)
        {
            this.package = package;
            this.passwordsToCrackCount = package.getPasswordsToCrack().Count();
//            Console.WriteLine("passwordsToCrackCount    " + passwordsToCrackCount);
            this.go = crackMethodFactory(package.getMethod());

            if (package.getMethod() == 1)
            {
                DirectoryInfo rootDir = new DirectoryInfo(path);
                if (dictionaryExists(rootDir))
                {
                    start();
                }
                else
                {
                    host.sendDictionary();
                    Console.WriteLine("Nie mam slownika");
                }
            }
            else
                start();
        }

        public Package getPackage()
        {
            return this.package;
        }

        public void start()
        {
            var timeStart = DateTime.Now;
            ClientResponse clientResponse;
            clientResponse = go.crackMethod(timeStart);

            double processingTime = DateTime.Now.Subtract(timeStart).TotalSeconds;
            clientResponse.setProcessingTime(processingTime);

            if (passwordsToCrackCount == clientResponse.getCrackedPasswords().Count)
                host.sendResponseWhenAllPasswordsFound(clientResponse);
            else
                host.nextPackage(clientResponse);
        }


        internal ICrackPassword crackMethodFactory(byte method)
        {
            if (method == 0)
                return new GoBrute(package);
            else
                return new GoSlownik(package, dictionaryName);
        }

        

        public void setDictionaryName(string dictionaryName)
        {
            this.dictionaryName = path + dictionaryName;
            if (File.Exists(this.dictionaryName))
            {
                File.Delete(this.dictionaryName);
                Console.WriteLine("Wywalilem plik");
            }
            Console.WriteLine("Odbieram plik ..............................");
        }

        public bool dictionaryExists(DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;

            try
            {
                files = root.GetFiles("*.*");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (FileInfo file in files)
                {
                    if (md5Hash.fileMatched(package.getDictionaryFileCheckSum(), file.FullName))
                        return true;
                }
            }
            return false;
        }

        public void appendDictionaryPart(byte[] bytes, int offset, int size)
        {
            //Console.WriteLine("nazwa slownika " + this.dictionaryName);
            using (FileStream fileStream = new FileStream(this.dictionaryName, FileMode.Append, FileAccess.Write))
            {
                fileStream.Write(bytes, offset, size);
                fileStream.Close();
                fileStream.Dispose();
            }
        }

        public string getDictionaryPath()
        {
            return dictionaryName;
        }


        public void nowyCzas(double s)
        {
            throw new NotImplementedException();
        }


        public void getClientsCounter(int count)
        {
            throw new NotImplementedException();
        }


        public void showResult(Result result)
        {
            throw new NotImplementedException();
        }


        public void activateBtStartWhenAllPasswordsFound(double avgProcessingTime)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            CallbackHandler call = new CallbackHandler();
            InstanceContext instanceContext = new InstanceContext(call);
            LHServiceClient client = new LHServiceClient(instanceContext);

            client.Open();
            Console.WriteLine("Połączono");
            call.setClient(client);
            client.addClient();

            Console.ReadLine();
        }
    }
}
