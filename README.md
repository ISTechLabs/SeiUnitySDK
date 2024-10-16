## SeiUnitySDK
SeiUnitySDK is a tool designed to simplify working with the Sei blockchain within Unity. By combining Unity’s rendering, physics, audio, and animation systems with the fast and efficient Sei blockchain, developers can unlock new possibilities in decentralized game development.

Video setup guide: https://www.youtube.com/watch?v=CnJ8eD0RIXg

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
Contract Execute
```C#
        public async void Execute()
        {
                var task = SeiSdkManager.Instance.Execute<TResponse>(senderAddress, contractAddress, transactionFee, msg, null, null);
                await task;
        {
```
         
Contract Query
```C#
        public async void Query()
        {
                var task = SeiSdkManager.Instance.Query<TResponse>(contractAddress, msg);
                await task;
        {
```
______

## **WEBGL**

+ Prepare webgl build
+ Install react example project https://www.npmjs.com/package/peacemaker-unity-react-sei-sdk
