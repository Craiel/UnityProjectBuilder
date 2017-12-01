namespace Assets.Scripts.SetupCode
{
    using Craiel.Audio;
    using Craiel.Audio.Contracts;
    using Craiel.Audio.Data;
    using Craiel.Essentials.Resource;
    using Craiel.GameData;
    using UnityEngine;
    using UnityEngine.Audio;

    public class AudioConfig : IAudioConfig
    {
        // -------------------------------------------------------------------
        // Public
        // -------------------------------------------------------------------
        public void Configure()
        {
            AudioCore.DynamicAudioSourceResource = ResourceKey.Create<GameObject>("Audio/DynamicAudioSource");
            AudioCore.MasterMixerResource = ResourceKey.Create<AudioMixer>("Audio/MasterMixer");
            
            GameRuntimeData.RegisterData<RuntimeAudioData>();
        }
    }
}