using SeiSDK;
using SeiSDK.WebCore;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class SampleAuth : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _testText;

    public async void Login()
    {
        var task = SeiSdkManager.Instance.LoginCompass();

        await task;

        if (task.IsCompletedSuccessfully)
        {
            _testText.text = task.Result.WalletAddress;
        }
    }
}
