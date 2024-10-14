using System;

namespace SeiSDK
{
    [Serializable]
    public class QueryRequest 
    {
        public string ContractAddress;
        public string Query;

        public QueryRequest(string contractAddress, string query)
        {
            ContractAddress = contractAddress;
            Query = query;
        }
    }
}
