using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LamaczHaselGUI.LHServiceRef;
using Shared;

namespace LamaczHaselGUI
{
    class HostConnectionHandler
    {

        public class CallbackHandler : ILHServiceCallback
        {
            private List<String> logi = new List<String>();
            private static readonly object SyncObject = new object();
            private ProcessingTimeHandler processingTimeHandler = ProcessingTimeHandler.Instance();
            private LHServiceClient client;
            private int clientCount;

            public void getClient(LHServiceClient client)
            {
                this.client = client;
            }

            public List<String> getLogi()
            {
                return this.logi;
            }
            public async void activateBtStartWhenAllPasswordsFound(double avgProcessingTime)
            {
                await Task.Delay((int)avgProcessingTime * 1000);
                Program.getMainWindow().btStart.Enabled = true;
                Program.getMainWindow().btStop.Enabled = false;
                Program.getMainWindow().nextTest();
                Program.getMainWindow().lbProces.ForeColor = System.Drawing.Color.Blue;
                Program.getMainWindow().lbProces.Text = "Zakończono";
            }

            public void nowyCzas(double time)
            {
                processingTimeHandler.addProcessingTime(time);
                logi.Add("czas jednej paczki: " + time);

            }

            public void getClientsCounter(int clientCount)
            {
                this.processingTimeHandler.setClientCount(clientCount);
                this.clientCount = clientCount;
            }

            public void getPackageCallback(Package package)
            {
                throw new NotImplementedException();
            }

            public void showResult(Result result)
            {
                double communicationTime = processingTimeHandler.getOperationTime() - result.getProcessingTime();
                Program.getMainWindow().textOdp.Text += "Czas operacji: "+ processingTimeHandler.getOperationTime() + Environment.NewLine;
                Program.getMainWindow().textOdp.Text += "Czas komunikacji: " + communicationTime + Environment.NewLine;
                Program.getMainWindow().textOdp.Text += result.ToString();

                var newLine = string.Format("{0};{1};{2}" + Environment.NewLine, processingTimeHandler.getOperationTime(), communicationTime, result.getProcessingTime());
                File.AppendAllText(clientCount + "_client.csv", newLine);
            }

            public void appendDictionaryPart(byte[] bytes, int offset, int size)
            {
                throw new NotImplementedException();
            }

            public void setDictionaryName(string dictionaryName)
            {
                throw new NotImplementedException();
            }

        }

        public HostConnectionHandler()
        {
            this.call = new CallbackHandler();
            this.instanceContext = new InstanceContext(this.call);
            this.host = new LHServiceClient(this.instanceContext);
        }
        private LHServiceClient host;
        private CallbackHandler call;
        private InstanceContext instanceContext;
        ProcessingTimeHandler processingTimeHandler = ProcessingTimeHandler.Instance();

        public List<String> getLogi()
        {
            return call.getLogi();
        }

        public void setPackage(Package package)
        {
            processingTimeHandler.resetProcessingTime();
            if (package.getAlphabet() == null)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Warning", "Nie ma znaków", buttons);
            }
            processingTimeHandler.startProcessingTime();
            
            this.host.setPackage(package);
        }

        public void open()
        {
            this.host.Open();
        }

        public void stopCracked()
        {
            this.host.stop();
        }
    }
}
