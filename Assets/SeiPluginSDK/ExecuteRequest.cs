using System;

namespace SeiSDK
{
    [Serializable]
    public class ExecuteRequest
    {
        public string SenderAddress;
        public string ContractAddress;
        public TransactionFee Fee;
        public string Message;
        public string Memo;
        public TransactionAmount[] Funds;

        public ExecuteRequest(string senderAddress, string contractAddress, TransactionFee transactionFee, string msg, string memo, TransactionAmount[] funds)
        {
            SenderAddress = senderAddress;
            ContractAddress = contractAddress;
            Fee = transactionFee;
            Message = msg;
            Memo = memo;
            Funds = funds;
        }
    }
}