using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [Serializable]
    public class ClientResponse
    {
        private double processingTime;
        private BigInteger packageIndex;
        private Dictionary<string, double> crackedPasswords = new Dictionary<string, double>();

        public void setProcessingTime(double processingTime)
        {
            this.processingTime = processingTime;
        }

        public double getProcessingTime()
        {
            return processingTime;
        }

        public void setPackageIndex(BigInteger packageIndex)
        {
            this.packageIndex = packageIndex;
        }

        public BigInteger getPackageIndex()
        {
            return packageIndex;
        }

        public void addCrackedPasswords(string crackedPassword, double processingTime)
        {
            crackedPasswords.Add(crackedPassword, processingTime);
        }

        public Dictionary<string, double> getCrackedPasswords()
        {
            return this.crackedPasswords;
        }
    }
}
