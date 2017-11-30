﻿namespace Assets.Scripts.SetupCode.Gym
{
    using Craiel.Audio;
    using Craiel.Essentials.Controllers;
    using Craiel.Essentials.Debug.Gym;
    using Craiel.Essentials.Event;
    using Craiel.Essentials.Input;
    using Craiel.Essentials.Resource;
    using Craiel.Essentials.Scene;
    using Craiel.GameData;

    public class SampleGym : DebugGymBase
    {
        // -------------------------------------------------------------------
        // Public
        // -------------------------------------------------------------------
        public void Awake()
        {
            this.InitEngine();

            InputStateDebug.Instance.Initialize();

            // Configure the input for the debug controllers
            FreeMovementController.ConfigureInput(InputStateDebug.Instance);
            MouseLookController.ConfigureInput(InputStateDebug.Instance);

            InputHandler.Instance.SwitchState(InputStateDebug.Instance);
        }

        // -------------------------------------------------------------------
        // Private
        // -------------------------------------------------------------------
        private void InitEngine()
        {
            this.InitDefaultNLog();

            SceneObjectController.InstantiateAndInitialize();

            BundleProvider.InstantiateAndInitialize();
            ResourceProvider.InstantiateAndInitialize();

            GameEvents.InstantiateAndInitialize();

            GameRuntimeData.InstantiateAndInitialize();
            GameRuntimeData.Instance.Load(Constants.GameDataResourceKey);

            AudioSystem.InstantiateAndInitialize();

            InputHandler.InstantiateAndInitialize();
        }
    }
}
