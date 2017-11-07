namespace SetupCode
{
    using Assets.Scripts.CoreGame.Input;
    using Assets.Scripts.Craiel.Audio;
    using Assets.Scripts.Craiel.Essentials.Controllers;
    using Assets.Scripts.Craiel.Essentials.Input;
    using Assets.Scripts.Craiel.Essentials.Resource;
    using Assets.Scripts.Craiel.Essentials.Scene;
    using Assets.Scripts.SetupCode;
    using UnityEngine;
    
    public class TestInit : MonoBehaviour
    {
        public void Awake()
        {
            SceneObjectController.InstantiateAndInitialize();
            
            BundleProvider.InstantiateAndInitialize();
            ResourceProvider.InstantiateAndInitialize();
            
            GameRuntimeData.InstantiateAndInitialize();
            GameRuntimeData.Instance.Load(Constants.GameDataResourceKey);
            
            AudioSystem.InstantiateAndInitialize();
            
            InputHandler.InstantiateAndInitialize();
            
            // Configure the input for the debug controllers
            FreeMovementController.ConfigureInput(InputStates.Default);
            MouseLookController.ConfigureInput(InputStates.Default);
        }
    }
}