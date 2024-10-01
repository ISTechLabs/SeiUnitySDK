using SeiSDK.Auth;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

namespace SeiSDK.WebCore
{
    public static class WebBrige
    {
        [DllImport("__Internal")]
        private static extern void OnLogin(string data);
        [DllImport("__Internal")]
        private static extern void OnExecute(string data);
        [DllImport("__Internal")]
        private static extern void OnQuery(string data);

        public static void Login(WebEventRequest webEventRequest)
        {
            var requstString = JsonUtility.ToJson(webEventRequest);
#if UNITY_WEBGL && !UNITY_EDITOR
            OnLogin(requstString);
#endif
        }

        public static void Execute(WebEventRequest webEventRequest)
        {
            var requstString = JsonUtility.ToJson(webEventRequest);
#if UNITY_WEBGL && !UNITY_EDITOR
            OnExecute(requstString);
#endif
        }

        public static void Query(WebEventRequest webEventRequest)
        {
            var queryString = JsonUtility.ToJson(webEventRequest);
#if UNITY_WEBGL && !UNITY_EDITOR
            OnQuery(queryString);
#endif
        }
    }
}
