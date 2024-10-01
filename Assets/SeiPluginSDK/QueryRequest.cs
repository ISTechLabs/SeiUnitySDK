using System;

namespace SeiSDK
{
    [Serializable]
    public class QueryRequest 
    {
        public string contractAddress;
        public string msg;

        public QueryRequest(string contractAddress, string msg)
        {
            this.contractAddress = contractAddress;
            this.msg = msg;
        }
    }
}
