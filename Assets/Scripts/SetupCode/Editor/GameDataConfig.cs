namespace Assets.Scripts.SetupCode.Editor
{
    using Assets.Scripts.Craiel.GameData.Contracts;
    using Assets.Scripts.Craiel.GameData.Editor.Builder;
    using Assets.Scripts.Craiel.GameData.Editor.EditorWindow;
    using Craiel.Audio.Editor;

    public class GameDataConfig : IGameDataConfig
    {
        // -------------------------------------------------------------------
        // Public
        // -------------------------------------------------------------------
        
        
        public void Configure()
        {
            GameDataBuilder.TargetFile = Constants.GameDataDataFile;

            GameDataEditorWindow.AddWorkSpace(1, "Test");
            GameDataEditorWindow.AddPanel<GameDataAudio>("Audio");
            // GameDataEditorWindow.AddPanel<GameDataVfx>("VFX");
        }
    }
}
