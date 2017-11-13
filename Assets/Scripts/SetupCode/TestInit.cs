namespace SetupCode
{
    using Assets.Scripts.CoreGame.Input;
    using Assets.Scripts.Craiel.Audio;
    using Assets.Scripts.Craiel.Essentials.Controllers;
    using Assets.Scripts.Craiel.Essentials.Input;
    using Assets.Scripts.Craiel.Essentials.IO;
    using Assets.Scripts.Craiel.Essentials.Logging;
    using Assets.Scripts.Craiel.Essentials.Resource;
    using Assets.Scripts.Craiel.Essentials.Scene;
    using Assets.Scripts.Craiel.GameData;
    using NLog;
    using NLog.Config;
    using NLog.Targets;
    using UnityEngine;
    
    public class TestInit : MonoBehaviour
    {
        // -------------------------------------------------------------------
        // Public
        // -------------------------------------------------------------------
        public void Awake()
        {
            this.InitNLog();
            
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

        // -------------------------------------------------------------------
        // Private
        // -------------------------------------------------------------------
        private void InitNLog()
        {
            if (!NLogInterceptor.IsInstanceActive)
            {
                NLogInterceptor.InstantiateAndInitialize();
            }

            UnityNLogRelay.InstantiateAndInitialize();

            // Step 1. Create configuration object 
            var config = new LoggingConfiguration();
            config.AddTarget("interceptor", NLogInterceptor.Instance.Target);

            var fileTarget = new FileTarget
            {
                ArchiveAboveSize = Constants.LogFileArchiveSize,
                MaxArchiveFiles = Constants.LogFileArchiveCount,
                KeepFileOpen = true,
                ConcurrentWrites = true,
                ArchiveOldFileOnStartup = true
            };

            config.AddTarget("file", fileTarget);

            var target = new CarbonDirectory(UnityEngine.Application.persistentDataPath);
            target.Create();

            UnityEngine.Debug.Log("NLog Path: " + target);

            // Step 3. Set target properties 
            fileTarget.FileName = target.GetUnityPath() + "/all.log";
            fileTarget.Layout = @"${date:format=HH\:mm\:ss.fff} [${threadid}] ${level} ${message}";

            var rule = new LoggingRule("*", LogLevel.Debug, fileTarget);
            config.LoggingRules.Add(rule);

            rule = new LoggingRule("*", LogLevel.Debug, NLogInterceptor.Instance.Target);
            config.LoggingRules.Add(rule);

            // Step 5. Activate the configuration
            LogManager.Configuration = config;
        }
    }
}