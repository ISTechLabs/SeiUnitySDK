using System;

namespace SeiSDK
{
    [Serializable]
    public class TransactionFee
    {
        public TransactionAmount amount;
        public long gas;

        public TransactionFee(TransactionAmount amount, long gas) 
        { 
            this.amount = amount; 
            this.gas = gas; 
        }
    }
}
