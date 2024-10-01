using System;

namespace SeiSDK
{
    [Serializable]
    public class ExecuteRequest
    {
        public string senderAddress;
        public string contractAddress;
        public TransactionFee transactionFee;
        public string msg;

        public ExecuteRequest(string senderAddress, string contractAddress, TransactionFee transactionFee, string msg)
        {
            this.senderAddress = senderAddress;
            this.contractAddress = contractAddress;
            this.transactionFee = transactionFee;
            this.msg = msg;
        }
    }
}