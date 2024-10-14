using System;

namespace SeiSDK
{
    [Serializable]
    public class TransactionFee
    {
        public TransactionAmount[] amount;
        public string gas;

        public TransactionFee(TransactionAmount amount, long gas) 
        { 
            this.amount = new TransactionAmount[1];
            this.amount[0] = amount;
            this.gas = gas.ToString(); 
        }
    }
}
