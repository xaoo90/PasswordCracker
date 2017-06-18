using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ConvertPasswordCode
    {
        public List<int> decToBase(BigInteger n, char[] pattern)
        {
            int newBase = pattern.Length;
            List<int> result = new List<int>();
            int index = 0;
            bool step = false;

            if (newBase < 1)
                return null;

            if (n == 0)
            {
                result.Clear();
                return result;
            }

            while (n > 0)
            {
                index = (int)(n % newBase - 1);
                if (index == -1)
                {
                    step = true;
                    result.Insert(0, newBase - 1);
                }
                else
                    result.Insert(0, index);
                if (step)
                {
                    n /= newBase;
                    n--;
                    step = false;
                }
                else
                    n /= newBase;
            }
            return result;
        }

        public String decToBaseString(BigInteger n, char[] pattern)
        {
            String result = "";
            try
            {
                foreach (var item in decToBase(n, pattern))
                    result += pattern[item];
            }
            catch (NullReferenceException)
            {
                return "Nie wybrano znaków"; 
            }
            return result;
        }


        private static int valueOf(char x, char[] pattern)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                if (x == pattern[i])
                    return ++i;
            }
            return -1;
        }

        public BigInteger baseToDec(String n, char[] pattern)
        {
            int baseOfN = pattern.Length;
            int i, x;
            BigInteger p = new BigInteger(1);
            BigInteger result = new BigInteger();

            if (baseOfN < 2)
                return 0;

            for (i = n.Length - 1; i >= 0; i--)
            {
                x = valueOf(n[i], pattern);
                if (x < 0)
                    return 0;
                result += (x * p);
                p *= baseOfN;
            }
            return result;
        }
    }
}
