using System;

namespace SeiSDK.WebCore
{
    public interface IWebRequest
    {
        Guid Guid { get; }
        void SetResult(string webData);
        void Cancel();
    }
}
