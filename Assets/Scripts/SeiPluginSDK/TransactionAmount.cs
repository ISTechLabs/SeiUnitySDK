using System;

namespace SeiSDK
{
    [Serializable]
    public class TransactionAmount
    {
        public long amount;
        public string denom;

        public TransactionAmount(long amount, string denom)
        {
            this.amount = amount;
            this.denom = denom;
        }
    }
}
