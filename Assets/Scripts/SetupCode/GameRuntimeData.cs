namespace Assets.Scripts.SetupCode
{
    using System.Collections.Generic;
    using System.IO;
    using Assets.Scripts.Craiel.Essentials;
    using Assets.Scripts.Craiel.Essentials.Enums;
    using Assets.Scripts.Craiel.Essentials.Scene;
    using Assets.Scripts.Craiel.GameData;
    using Craiel.Audio.Data;
    using Craiel.Essentials.Resource;
    using Craiel.GameData.Contracts;
    using NLog;
    using UnityEngine;

    public class GameRuntimeData : UnitySingletonBehavior<GameRuntimeData>, IGameDataRuntimeResolver
    {
        private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly GameDataReader reader;
        
        // -------------------------------------------------------------------
        // Constructor
        // -------------------------------------------------------------------
        public GameRuntimeData()
        {
            this.reader = InitializeReader();
        }

        // -------------------------------------------------------------------
        // Public
        // -------------------------------------------------------------------
        public bool IsLoaded { get; private set; }

        public override void Initialize()
        {
            this.RegisterInController(SceneObjectController.Instance, SceneRootCategory.System, true);

            base.Initialize();
        }
        
        public bool GetAll<T>(IList<T> target)
        {
            return this.reader.GetAll(target);
        }

        public T Get<T>(GameDataId dataId)
        {
            return this.reader.Get<T>(dataId);
        }
        
        public GameDataId GetRuntimeId(GameDataRuntimeRefBase refData)
        {
            return this.reader.GetRuntimeId(refData);
        }

        public void Load(ResourceKey resourceKey)
        {
            using (var resource = ResourceProvider.Instance.AcquireOrLoadResource<TextAsset>(resourceKey))
            {
                if (resource == null || resource.Data == null)
                {
                    Logger.Error("Could not load RuntimeData from resource {0}", resourceKey);
                    return;
                }
                
                Load(resource.Data.bytes);
            }
        }

        public void Load(byte[] data)
        {
            Logger.Info("Loading Game data: {0} bytes", data.Length);

            using (var stream = new MemoryStream(data))
            {
                this.reader.Load(stream);
            }
            
            this.IsLoaded = true;
        }

        public static GameDataReader InitializeReader()
        {
            var reader = new GameDataReader();

            reader.RegisterData<RuntimeAudioData>();
            // reader.RegisterData<RuntimeVfxData>();

            return reader;
        }
    }
}
