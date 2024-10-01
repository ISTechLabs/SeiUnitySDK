using System;
using System.Threading.Tasks;
using UnityEngine;

namespace SeiSDK.WebCore
{
    public class WebPluginRequest<TResponse> : IWebRequest
    {
        private TaskCompletionSource<TResponse> _taskCompletionSource;
        private Guid _guid;

        public Guid Guid => _guid;

        public WebPluginRequest()
        {
            _guid = Guid.NewGuid();
        }

        public Task<TResponse> Execute<TRequest>(Action<WebEventRequest> action, TRequest r)
        {
            _taskCompletionSource = new TaskCompletionSource<TResponse>();
            action?.Invoke(new WebEventRequest() { Id = _guid.ToString(), Request = JsonUtility.ToJson(r)});
            return _taskCompletionSource.Task;
        }

        public void SetResult(string webData)
        {
            var data = JsonUtility.FromJson<TResponse>(webData);

            if (data != null)
            {
                _taskCompletionSource.SetResult(data);
            }
            else
            {
                Debug.LogError("Can't Parse data " + webData);
            }
        }

        public void Cancel()
        {
            _taskCompletionSource.SetCanceled();
        }
    }
}
