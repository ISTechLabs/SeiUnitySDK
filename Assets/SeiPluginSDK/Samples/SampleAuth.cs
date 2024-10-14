using TMPro;
using UnityEngine;
using Task = System.Threading.Tasks.Task;

namespace SeiSDK
{
    public class SampleAuth : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _testText;
        [SerializeField] private string _contractAddress;
        
        private Wallet _wallet;

        public async void Login()
        {
            var task = SeiSdkManager.Instance.LoginCompass();

            while (!task.IsCompleted)
            {
                await Task.Yield();
            }

            if (task.IsCompletedSuccessfully)
            {
                _wallet = task.Result;
                _testText.text = task.Result.WalletAddress;
            }
        }
    }
}
