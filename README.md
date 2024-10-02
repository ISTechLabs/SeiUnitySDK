## SeiUnitySDK
SeiUnitySDK is a tool designed to simplify working with the Sei blockchain within Unity. By combining Unity’s rendering, physics, audio, and animation systems with the fast and efficient Sei blockchain, developers can unlock new possibilities in decentralized game development.
______
## **Setup in unity**

+ Import .unitypackage to your project
+ Create new gameobject in scene
+ Add SeiSDKManager componet
______

## **Usage**

Compass login 
```C#
        public async void Login()
        {
            var task = SeiSdkManager.Instance.LoginCompass();
            await task;
        }
```
______

## **WEBGL**

+ Prepare webgl build
+ Install react example project https://www.npmjs.com/package/peacemaker-unity-react-sei-sdk
