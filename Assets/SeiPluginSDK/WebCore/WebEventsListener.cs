using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace SeiSDK.WebCore
{
    public class WebEventsListener : MonoBehaviour
    {
        private List<IWebRequest> _requests = new List<IWebRequest>();

        public Task<TResponse> Request<TResponse, TRequest>(Action<WebEventRequest> action, TRequest request)
        {
            WebPluginRequest<TResponse> webRequest = new WebPluginRequest<TResponse>();
            _requests.Add(webRequest);
            return webRequest.Execute(action, request);
        }

        public void WebResponse(string response)
        {
            WebEventResponse webEvent = JsonUtility.FromJson<WebEventResponse>(response);

            if (webEvent == null)
                return;

            var req = _requests.FirstOrDefault(r => r.Guid.ToString() == webEvent.Id.ToString());

            if (req == null)
                return;

            if (webEvent.Response != null && webEvent.Response != string.Empty) {
                if (req != null)
                {
                    req.SetResult(webEvent.Response);
                }
            }
            else
            {
                req.Cancel();
                Debug.LogError(webEvent.Error);
            }

            _requests.Remove(req);
        }
    }
}
