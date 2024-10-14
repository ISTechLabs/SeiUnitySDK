using System;

namespace SeiSDK
{
    [Serializable]
    public class TransactionAmount
    {
        public string amount;
        public string denom;

        public TransactionAmount(long amount, string denom)
        {
            this.amount = amount.ToString();
            this.denom = denom;
        }

        public TransactionAmount(float amount, string denom)
        {
            this.amount = amount.ToString();
            this.denom = denom;
        }
    }
}
