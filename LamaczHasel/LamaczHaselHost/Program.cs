using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using LHWcfServiceLibrary;

namespace LamaczHaselHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8001/LamaczHasel/");
            ServiceHost selfHost = new ServiceHost(typeof(LHService), new Uri[] { baseAddress });
            try
            {

                WSDualHttpBinding binding = new WSDualHttpBinding();
                binding.MaxBufferPoolSize = 2147483647;
                binding.MaxReceivedMessageSize = 2147483647;
                binding.OpenTimeout = new TimeSpan(0, 0, 10);
                binding.CloseTimeout = new TimeSpan(0, 0, 10);
                binding.SendTimeout = new TimeSpan(0, 0, 10);
                binding.ReceiveTimeout = new TimeSpan(0, 10, 0);


                selfHost.AddServiceEndpoint(typeof(ILHService), binding, "LHService");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Find<ServiceDebugBehavior>().IncludeExceptionDetailInFaults = true;
                selfHost.Description.Behaviors.Add(smb);
                selfHost.Open();
                Console.WriteLine("Serwis działa....");
                Console.WriteLine("Nacisnij <ENTER> by zakonczyc.");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Przechwyciłem wyjatek: {0}", ce.Message);
                Console.ReadLine();
                selfHost.Abort();
            }

        }
    }
}
