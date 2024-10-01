using System;

namespace SeiSDK.Auth
{
    [Serializable]
    public class WalletRequest
    {
        public string ChainId;
        public string RestUrl;
        public string RpcUrl;
    }
}
