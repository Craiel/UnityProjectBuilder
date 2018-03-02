using IGameDataEditorConfig = Craiel.GameData.Editor.Contracts.IGameDataEditorConfig;

namespace Assets.Scripts.SetupCode.Editor
{
    using Assets.Scripts.Craiel.GameData.Contracts;
    using Assets.Scripts.Craiel.GameData.Editor.Builder;
    using Craiel.Audio.Editor;
    using Craiel.GameData.Editor.Window;
    using Craiel.VFX.Editor;

    public class GameDataEditorConfig : IGameDataEditorConfig
    {
        // -------------------------------------------------------------------
        // Public
        // -------------------------------------------------------------------
        public void Configure()
        {
            GameDataBuilder.TargetFile = Constants.GameDataDataFile;

            GameDataEditorWindow.AddWorkSpace(1, "Test");
            GameDataEditorWindow.AddContent<GameDataAudio>("Audio"); 
            GameDataEditorWindow.AddContent<GameDataVFX>("VFX");
        }
    }
}
