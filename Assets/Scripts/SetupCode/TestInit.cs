namespace SetupCode
{
    using Assets.Scripts.Craiel.Audio;
    using Assets.Scripts.Craiel.Essentials.Resource;
    using Assets.Scripts.Craiel.Essentials.Scene;
    using Assets.Scripts.SetupCode;
    using UnityEngine;
    
    public class TestInit : MonoBehaviour
    {
        public void Start()
        {
            SceneObjectController.InstantiateAndInitialize();
            
            BundleProvider.InstantiateAndInitialize();
            ResourceProvider.InstantiateAndInitialize();
            
            GameRuntimeData.InstantiateAndInitialize();
            GameRuntimeData.Instance.Load(Constants.GameDataResourceKey);
            
            AudioSystem.InstantiateAndInitialize();
        }
    }
}