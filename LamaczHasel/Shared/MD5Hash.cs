using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class MD5Hash
    {

        MD5 md5Hash = MD5.Create();
        private static readonly object SyncObject = new object();

        public string getMd5CheckSum(string fileName)
        {
            using (var stream = File.OpenRead(fileName))
            {
                return Encoding.Default.GetString(md5Hash.ComputeHash(stream));
            }
        }

        public string getMd5Hash(string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public bool verifyMd5Hash(List<string> hashes, string passwordToCrack)
        {
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            string crackedPassword = null;
            string passwordToCrackHash = getMd5Hash(passwordToCrack);
            lock (SyncObject)
            {
                foreach (var item in hashes)
                {
                    if (comparer.Compare(item, passwordToCrackHash) == 0)
                    {
                        //Console.WriteLine("znaleziony hash " + item);
                        crackedPassword = item;
                        break;
                    }
                }
                if (crackedPassword != null)
                {
                    hashes.Remove(crackedPassword);
                    return true;
                }
            }

            return false;
        }

        public bool fileMatched(string checkSum, string dictionaryPath)
        {
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (comparer.Compare(checkSum, getMd5CheckSum(dictionaryPath)) == 0)
                return true;
            else
                return false;
        }
    }
}