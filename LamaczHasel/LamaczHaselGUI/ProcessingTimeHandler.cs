using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamaczHaselGUI
{
    class ProcessingTimeHandler
    {
        private static ProcessingTimeHandler instance;
        private static readonly object m_oPadLock = new object();

        private DateTime operationTimeStart;
        private DateTime operationTimeEnd;
        private double processingTime = 0;
        private int clientCount;

        public void setClientCount(int count)
        {
            this.clientCount = count;
        }

        public void setOperationTimeStart(DateTime operationTimeStart)
        {
            this.operationTimeStart = operationTimeStart;
        }
        public void setOperationTimeEnd(DateTime operationTimeEnd)
        {
            this.operationTimeEnd = operationTimeEnd;
        }
        public void setProcessingTime(double processingTime)
        {
            this.processingTime = processingTime;
        }

        public DateTime getOperationTimeStart()
        {
            return operationTimeStart;
        }

        public DateTime getOperationTimeEnd()
        {
            return operationTimeEnd;
        }

        public double getProcessingTime()
        {
            return processingTime / clientCount;
        }

        public void addProcessingTime(double processingTime)
        {
            this.processingTime += processingTime;
        }
        public void startProcessingTime()
        {
            operationTimeStart = DateTime.Now;
        }
        //public void endProcessingTime()
        //{
        //    operationTimeEnd = DateTime.Now;
        //}
        public double getOperationTime()
        {
            return DateTime.Now.Subtract(operationTimeStart).TotalSeconds;
        }

        public double getCommunicationTime()
        {
            return getOperationTime() - getProcessingTime();
        }

        public static ProcessingTimeHandler Instance()
        {
            ProcessingTimeHandler result;
            lock (ProcessingTimeHandler.m_oPadLock)
            {
                if (ProcessingTimeHandler.instance == null)
                {
                    ProcessingTimeHandler.instance = new ProcessingTimeHandler();
                }
                result = ProcessingTimeHandler.instance;
            }
            return result;
        }


        public override string ToString()
        {
            return string.Concat(new object[]
			{
				"Czas operacji: " + getOperationTime() + " s" + Environment.NewLine
                + "Czas obliczeń " + this.getProcessingTime() + " s" + Environment.NewLine
                + "Czas komunikacji " + getCommunicationTime() + " s"
			});
        }

        public void resetProcessingTime()
        {
            processingTime = 0;
        }

    }
}
