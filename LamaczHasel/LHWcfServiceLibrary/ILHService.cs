using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Shared;

namespace LHWcfServiceLibrary
{
    [ServiceContract(SessionMode = SessionMode.Required,
    CallbackContract = typeof(ILHServiceCallback))]

    public interface ILHService
    {
        [OperationContract(IsOneWay = true)]
        void setPackage(Package package);
        [OperationContract(IsOneWay = true)]
        void addClient();
        [OperationContract(IsOneWay = true)]
        void stop();

        [OperationContract(IsOneWay = true)]
        void sendDictionary();

        [OperationContract(IsOneWay = true)]
        void nextPackage(ClientResponse clientResponse);
        [OperationContract(IsOneWay = true)]
        void sendResponseWhenAllPasswordsFound(ClientResponse clientResponse);
    }

    public interface ILHServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void getPackageCallback(Package package);

        [OperationContract(IsOneWay = true)]
        void setDictionaryName(string dictionaryName);

        [OperationContract(IsOneWay = true)]
        void appendDictionaryPart(byte[] bytes, int offset, int size);

        [OperationContract(IsOneWay = true)]
        void activateBtStartWhenAllPasswordsFound(double avgProcessingTime);

        [OperationContract(IsOneWay = true)]
        void showResult(Result result);

        [OperationContract(IsOneWay = true)]
        void nowyCzas(double s);

        [OperationContract(IsOneWay = true)]
        void getClientsCounter(int count);

    }

}