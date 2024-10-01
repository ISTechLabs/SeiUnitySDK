using System;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace SeiSDK
{
    public class SampleAuth : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _testText;

        public async void Login()
        {
            var task = SeiSdkManager.Instance.LoginCompass();

            while (!task.IsCompleted)
            {
                await Task.Yield();
            }

            if (task.IsCompletedSuccessfully)
            {
                _testText.text = task.Result.WalletAddress;
            }
        }
    }
}
