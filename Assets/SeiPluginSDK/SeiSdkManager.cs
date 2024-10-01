using UnityEngine;
using SeiSDK.Auth;
using System.Threading.Tasks;

#if UNITY_WEBGL
using SeiSDK.WebCore;
#endif


namespace SeiSDK
{
    public class SeiSdkManager : MonoBehaviour
    {
        public static SeiSdkManager Instance;

        [SerializeField] private string _chainId = "atlantic-2";
        [SerializeField] private string _restUrl = "https://rest.atlantic-2.seinetwork.io";
        [SerializeField] private string _rpcUrl = "https://rpc.atlantic-2.seinetwork.io";

#if UNITY_WEBGL
        private WebEventsListener _seiSdkEventsListener;
#endif

        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;

#if UNITY_WEBGL
                _seiSdkEventsListener = gameObject.AddComponent<WebEventsListener>();
#endif
                DontDestroyOnLoad(this);
            }
            else
                Destroy(gameObject);
        }

        public Task<Wallet> LoginCompass()
        {
#if UNITY_WEBGL
            return _seiSdkEventsListener.Request<Wallet, WalletRequest>(req => WebBrige.Login(req), new WalletRequest() { ChainId = _chainId, RestUrl = _restUrl, RpcUrl = _rpcUrl });
#else
            Debug.LogError("Login with unsupported platform");
            return null;
#endif
        }

        public Task<TResponse> Execute<TResponse>(string senderAddress, string contractAddress, TransactionFee transactionFee, string msg)
        {
            ExecuteRequest executeRequest = new ExecuteRequest(senderAddress, contractAddress, transactionFee, msg);

#if UNITY_WEBGL
            return _seiSdkEventsListener.Request<TResponse, ExecuteRequest>(req => WebBrige.Execute(req), executeRequest);
#else
            Debug.LogError("Login with unsupported platform");
            return null;
#endif
        }

        public Task<TResponse> Query<TResponse>(string contractAddress, string msg)
        {
            QueryRequest queryRequest = new QueryRequest(contractAddress, msg);

#if UNITY_WEBGL
            return _seiSdkEventsListener.Request<TResponse, QueryRequest>(req => WebBrige.Query(req), queryRequest);
#else
            Debug.LogError("Login with unsupported platform");
            return null;
#endif
        }
    }
}
