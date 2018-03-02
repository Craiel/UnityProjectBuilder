namespace Assets.Scripts.SetupCode.Editor
{
    using Craiel.Audio.Editor;
    using Craiel.VFX.Editor;
    using Craiel.VFX.Editor.Contracts;

    public class VFXEditorConfg : IVFXEditorConfig
    {
        // -------------------------------------------------------------------
        // Public
        // -------------------------------------------------------------------
        public void Configure()
        {
            // Register the audio components
            VFXEditorCore.AddComponent<AudioVFXMusicEditorComponent>();
            VFXEditorCore.AddComponent<AudioVFXSFXEditorComponent>(); 
        }
    }
}