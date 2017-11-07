namespace Assets.Scripts.CoreGame
{
    using Craiel.Audio.Contracts;
    using Craiel.Essentials;
    using Craiel.Essentials.Resource;
    using SetupCode;
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
            AudioCore.GameDataRuntimeResolver = GameRuntimeData.Instance;
        }
    }
}