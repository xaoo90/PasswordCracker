using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [Serializable]
    public class Package
    {
        public Package() { }
        
        public Package(List<char> alphabet, BigInteger firstIndex, int sizePackage, List<string> passwordsToCrack){
        this.alphabet = alphabet;
        this.firstIndex = firstIndex;
        this.sizePackage = sizePackage;
        this.method = 0;
        this.passwordsToCrack = passwordsToCrack;
        this.dictionaryFileCheckSum = "";
        }

        private List<char> alphabet = new List<char>();
        private BigInteger firstIndex;
        private int sizePackage;
        private byte method;
        private int transformationFlags;
        private List<string> passwordsToCrack = new List<string>();
        private string dictionaryFileCheckSum;

        public void addCharToAlphabet(char s)
        {
            alphabet.Add(s);
        }

        public void setAlphabet(List<char> alphabet)
        {
            this.alphabet = alphabet;
        }
        
        public List<char> getAlphabet()
        {
            return this.alphabet;
        }
        public void clearAlphabet()
        {
            this.alphabet.Clear();
        }

        public BigInteger getFirstIndex()
        {
            return firstIndex;
        }

        public void setFirstIndex(BigInteger firstIndex)
        {
            this.firstIndex = firstIndex;
        }

        public int getSizePackage()
        {
            return sizePackage;
        }
        public void setSizePackage(int sizePackage)
        {
            this.sizePackage = sizePackage;
        }

        public byte getMethod()
        {
            return method;
        }
        public void setMethod(byte method)
        {
            this.method = method;
        }

        public int getTransformationFlags()
        {
            return transformationFlags;
        }

        public void setTransformationFlags(int transformationFlags)
        {
            this.transformationFlags = transformationFlags;
        }


        public void addPasswordsToCrack(string s)
        {
            passwordsToCrack.Add(s);
        }

        public void setPasswordsToCrack(List<string> passwordsToCrack)
        {
            this.passwordsToCrack = passwordsToCrack;
        }

        public List<string> getPasswordsToCrack()
        {
            return this.passwordsToCrack;
        }
        public void clearPasswordsToCrack()
        {
            this.passwordsToCrack.Clear();
        }

        public string getDictionaryFileCheckSum()
        {
            return dictionaryFileCheckSum;
        }
        public void setDictionaryFileCheckSum(string dictionaryFileCheckSum)
        {
            this.dictionaryFileCheckSum = dictionaryFileCheckSum;
        }

    }
}
