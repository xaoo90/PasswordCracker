using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LamaczHaselClient
{
    class Util
    {
        public static BigInteger amountCombination(int start, int end, double amountSign)
        {
            BigInteger result = 0;
            for (double i = start; i <= end; i++)
            {
                result = result + new BigInteger(Math.Pow(amountSign, i));
            }
            return result;
        }

        public static BigInteger amountCombination(int end, double amountSign)
        {
            return amountCombination(1, end, amountSign);
        }
    }
}
