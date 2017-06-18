using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [Serializable]
    public class Result
    {
        private double processingTime;
        private string hash;
        private string password;

        public void setProcessingTime(double processingTime)
        {
            this.processingTime = processingTime;
        }

        public double getProcessingTime()
        {
            return processingTime;
        }

        public void setHash(string hash)
        {
            this.hash = hash;
        }

        public string getHash()
        {
            return hash;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return password;
        }

        public override string ToString()
        {
            return string.Concat(new object[]
			{
				"Czas łamania hasła: " + this.processingTime + "s" + Environment.NewLine
                + "Hasło: " + this.password + Environment.NewLine
                + "MD5Hash: " + this.hash + Environment.NewLine + Environment.NewLine
			});
        }

    }
}
