using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shared;

namespace LamaczHaselClient
{
    class GoSlownik : ICrackPassword
    {
        #region Private variables

        private int procesorCount = Environment.ProcessorCount;
        private ClientResponse clientResponse = new ClientResponse();
        private DateTime startTime;

        #endregion
        #region odSerwera

        private int firstIndex;
        private int sizePackage;
        private string dictionaryPath;
        private int transformationFlags;
        private List<string> passwordsToCrack;

        #endregion

        public GoSlownik() { }

        public GoSlownik(Package package)
        {
            this.dictionaryPath = "plik2.txt";
            this.sizePackage = package.getSizePackage();
            this.firstIndex = (int)package.getFirstIndex();
            this.transformationFlags = package.getTransformationFlags();
            this.passwordsToCrack = package.getPasswordsToCrack();
            this.clientResponse.setPackageIndex(firstIndex);
        }

        public GoSlownik(Package package, string dictionaryPath)
            : this(package)
        {
            this.dictionaryPath = dictionaryPath;
        }


        #region Private Method

        #region Index

        private int getIndexThread(int i)
        {
            int index = sizePackage / procesorCount;
            if (sizePackage % procesorCount > 0)
                index++;
            return index * i + firstIndex;
        }

        private int getPackageThread(int i)
        {
            int index = sizePackage / procesorCount;
            if (sizePackage % procesorCount > 0)
            {
                index++;
                if (i == procesorCount - 1)
                {
                    return sizePackage - (procesorCount - 1) * index;
                }
            }
            return index;
        }

        #endregion

        public static String addNumber(String password, int number)
        {
            return password + number;
        }

        public ClientResponse crackMethod(DateTime startTime)
        {
            this.startTime = startTime;
            List<Thread> threadList = new List<Thread>();
            for (int i = 0; i < procesorCount; i++)
            {
                Thread thread = new Thread(this.threadWorker);
                threadList.Add(thread);
                thread.Start(i);
            }

            foreach (Thread item in threadList)
            {
                item.Join();
            }


            return clientResponse;
        }

        #endregion

        private void threadWorker(object threadIndex)
        {
            int i = (int)threadIndex;
            MD5Hash md5hash = new MD5Hash();
            string transString;
            var lst = File.ReadLines(dictionaryPath).Skip(getIndexThread(i) - 1).Take(getPackageThread(i));
            foreach (var item in lst)
            {
                if (md5hash.verifyMd5Hash(passwordsToCrack, item))
                    clientResponse.addCrackedPasswords(item, DateTime.Now.Subtract(startTime).TotalSeconds);
                #region przeksztalcenia
                foreach (int itemEnum in Enum.GetValues(typeof(Transformations)))
                {

                    if ((transformationFlags & itemEnum) == 1)
                    {
                        transString = PasswordTransformator.addNumber(item, 1);
                        if (md5hash.verifyMd5Hash(passwordsToCrack, transString))
                            clientResponse.addCrackedPasswords(transString, DateTime.Now.Subtract(startTime).TotalSeconds);
                    }
                    if ((transformationFlags & itemEnum) == 2)
                    {
                        transString = PasswordTransformator.addSamePassword(item);
                        if (md5hash.verifyMd5Hash(passwordsToCrack, transString))
                            clientResponse.addCrackedPasswords(transString, DateTime.Now.Subtract(startTime).TotalSeconds);
                    }
                    if ((transformationFlags & itemEnum) == 4)
                    {
                        transString = PasswordTransformator.firstUpperCase(item);
                        if (md5hash.verifyMd5Hash(passwordsToCrack, transString))
                            clientResponse.addCrackedPasswords(transString, DateTime.Now.Subtract(startTime).TotalSeconds);
                    }
                    if ((transformationFlags & itemEnum) == 8)
                    {
                        transString = PasswordTransformator.makeUpper(item, 1);
                        if (md5hash.verifyMd5Hash(passwordsToCrack, transString))
                            clientResponse.addCrackedPasswords(transString, DateTime.Now.Subtract(startTime).TotalSeconds);
                    }
                    if ((transformationFlags & itemEnum) == 16)
                    {

                    }
                    if ((transformationFlags & itemEnum) == 32)
                    {

                    }
                    if ((transformationFlags & itemEnum) == 64)
                    {

                    }
                    if ((transformationFlags & itemEnum) == 128)
                    {

                    }
                    if ((transformationFlags & itemEnum) == 256)
                    {

                    }
                    if ((transformationFlags & itemEnum) == 512)
                    {

                    }
                    if ((transformationFlags & itemEnum) == 1024)
                    {

                    }
                    if ((transformationFlags & itemEnum) == 2048)
                    {

                    }
                    if ((transformationFlags & itemEnum) == 4096)
                    {

                    }
                }
                #endregion
                if (passwordsToCrack.Count() == 0)
                    return;
            }

            #region przeksztalcenia
            
            /*string transString;
            foreach (var lin in lines)
            {
                if (md5hash.verifyMd5Hash(passwordsToCrack, lin))
                    clientResponse.addCrackedPasswords(lin, DateTime.Now.Subtract(startTime).TotalSeconds);
                foreach (int item in Enum.GetValues(typeof(Transformations)))
                {

                    if ((transformationFlags & item) > 0)
                    {
                        MethodInfo methodInfo = this.GetType().GetMethod("addNumber");
                        ParameterInfo[] parameters = methodInfo.GetParameters();
                        if (methodInfo != null)
                        {
                            object[] parametersArray = new object[] { lin, 1 };
                            object result2 = null;
                            result2 = methodInfo.Invoke(this, parametersArray);
                        }
                    }

                    if ((transformationFlags & item) == 1)
                    {
                        transString = PasswordTransformator.addNumber(lin,1);
                        if (md5hash.verifyMd5Hash(passwordsToCrack, lin))
                            clientResponse.addCrackedPasswords(lin, DateTime.Now.Subtract(startTime).TotalSeconds);
                    }
                    if ((transformationFlags & item) == 2)
                    {
                        transString = PasswordTransformator.addSamePassword(lin);
                        if (md5hash.verifyMd5Hash(passwordsToCrack, lin))
                            clientResponse.addCrackedPasswords(lin, DateTime.Now.Subtract(startTime).TotalSeconds);
                    }
                    if ((transformationFlags & item) == 4)
                    {
                        transString = PasswordTransformator.firstUpperCase(lin);
                        if (md5hash.verifyMd5Hash(passwordsToCrack, lin))
                            clientResponse.addCrackedPasswords(lin, DateTime.Now.Subtract(startTime).TotalSeconds);
                    }
                    if ((transformationFlags & item) == 8)
                    {
                        transString = PasswordTransformator.makeUpper(lin, 1);
                        if (md5hash.verifyMd5Hash(passwordsToCrack, lin))
                            clientResponse.addCrackedPasswords(lin, DateTime.Now.Subtract(startTime).TotalSeconds);
                    }
                    if ((transformationFlags & item) == 16)
                    {

                    }
                    if ((transformationFlags & item) == 32)
                    {

                    }
                    if ((transformationFlags & item) == 64)
                    {

                    }
                    if ((transformationFlags & item) == 128)
                    {

                    }
                    if ((transformationFlags & item) == 256)
                    {

                    }
                    if ((transformationFlags & item) == 512)
                    {

                    }
                    if ((transformationFlags & item) == 1024)
                    {

                    }
                    if ((transformationFlags & item) == 2048)
                    {

                    }
                    if ((transformationFlags & item) == 4096)
                    {

                    }
                }
            }*/
            #endregion
        }

        public string getDictionaryPath()
        {
            return dictionaryPath;
        }

        public int getFirstIndex()
        {
            return firstIndex;
        }

        public int getSizePackage()
        {
            return sizePackage;
        }

        public int getTransformationFlags()
        {
            return transformationFlags;
        }

        public void setTransformationFlags(int transformationFlags)
        {
            this.transformationFlags = transformationFlags;
        }


    }
}
