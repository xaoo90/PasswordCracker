using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using LamaczHaselClient.LHServiceRef;
using Shared;

namespace LamaczHaselClient
{
    class GoBrute : ICrackPassword
    {
        private bool isMatched = false;

        private int charactersToTestLength = 0;
        private static int processorCount = Environment.ProcessorCount;
        private ClientResponse clientResponse = new ClientResponse();
        ConvertPasswordCode convert = new ConvertPasswordCode();
        private DateTime startTime;

        private int[] sizePackageThread = new int[processorCount];

        #region odSerwera

        private int sizePackage;
        private char[] charactersToTest;
        private BigInteger firstIndex;
        private List<string> passwordsToCrack;

        #endregion

        private int counter;

        public GoBrute() { }

        public GoBrute(Package package)
        {
            this.sizePackage = package.getSizePackage();
            this.firstIndex = package.getFirstIndex();
            this.charactersToTest = package.getAlphabet().ToArray();
            this.counter = sizePackage;
            this.passwordsToCrack = package.getPasswordsToCrack();
            this.clientResponse.setPackageIndex(firstIndex);
        }


        public ClientResponse crackMethod(DateTime startTime)
        {
            this.startTime = startTime;
            List<Thread> threadList = new List<Thread>();
            for (int i = 0; i < processorCount; i++)
            {
                Thread thread = new Thread(this.threadWorker);
                threadList.Add(thread);
                thread.Start(i);
            }

            foreach (Thread item in threadList)
                item.Join();

            return clientResponse;
        }

        private void threadWorker(object threadIndex)
        {
            int threadNumber = (int)threadIndex;

            sizePackageThread[threadNumber] = getPackageThread(threadNumber);

            charactersToTestLength = charactersToTest.Length;
            List<int> startIndexes = convert.decToBase(getIndexThread(threadNumber), charactersToTest);

            int estimatedPasswordLength = 0;
            estimatedPasswordLength = startIndexes.Count - 1;

            while (!isMatched && sizePackageThread[threadNumber] > 0)
            {
                estimatedPasswordLength++;
                startBruteForce(estimatedPasswordLength, startIndexes, threadNumber);
            }
        }

        private void startBruteForce(int keyLength, List<int> startIndexes, int threadNumber)
        {
            var keyChars = createCharArray(keyLength, charactersToTest[0]);

            createNewKey(0, keyChars, keyLength, startIndexes, threadNumber);
        }

        private char[] createCharArray(int length, char defaultChar)
        {
            return (from c in new char[length] select defaultChar).ToArray();
        }

        private void createNewKey(int currentCharPosition, char[] keyChars, int keyLength, List<int> startIndexes, int threadNumber)
        {
            int indexOfLastChar = keyLength - 1;
            int j;
            if (startIndexes.Count > 0)
            {
                j = startIndexes[0];
                startIndexes.RemoveAt(0);
            }
            else
                j = 0;

            var nextCharPosition = currentCharPosition + 1;

            MD5Hash md5hash = new MD5Hash();

            for (int i = j; i < charactersToTestLength; i++)
            {

                if (!isMatched && sizePackageThread[threadNumber] > 0)
                {
                    keyChars[currentCharPosition] = charactersToTest[i];

                    if (currentCharPosition < indexOfLastChar)
                    {
                        createNewKey(nextCharPosition, keyChars, keyLength, startIndexes, threadNumber);
                    }
                    else
                    {
                        sizePackageThread[threadNumber]--;

                        if (md5hash.verifyMd5Hash(passwordsToCrack, new String(keyChars)))
                        {
                            clientResponse.addCrackedPasswords(new String(keyChars), DateTime.Now.Subtract(startTime).TotalSeconds);
                        }
                        if (passwordsToCrack.Count() == 0)
                        {
                            isMatched = true;
                            return;
                        }
                    }
                }
                else
                    return;             
            }
        }

        private BigInteger getIndexThread(int i)
        {
            int index = sizePackage / processorCount;
            if (sizePackage % processorCount > 0)
                index++;
            return index * i + firstIndex;
        }

        private int getPackageThread(int i)
        {
            int index = sizePackage / processorCount;
            if (sizePackage % processorCount > 0)
            {
                index++;
                if (i == processorCount - 1)
                    return sizePackage - (processorCount - 1) * index;
            }
            return index;
        }


        public char[] getCharactersToTest()
        {
            return charactersToTest;
        }

        public int getCharactersToTestLength()
        {
            return charactersToTest.Length;
        }

        public Boolean getMatched()
        {
            return isMatched;
        }
        public System.Numerics.BigInteger getFirstIndex()
        {
            return firstIndex;
        }
    }
}
