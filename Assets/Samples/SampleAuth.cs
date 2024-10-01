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

    public void Test()
    {
        SeiSdkManager.Instance.GetComponent<WebEventsListener>()
            .WebResponse("{\"Id\":\"610861da-1a92-41d4-ad1b-a3126455e802\",\"Response\":\"{\\\"WalletAddress\\\":\\\"sei1nhfnungtfgvjq2rshzuw2gl0sde5xmynmpm5gc\\\"}\",\"Error\":\"\"}\r\n");
    }
}
