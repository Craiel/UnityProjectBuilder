﻿namespace Assets.Scripts.SetupCode.Editor
{
    using Assets.Scripts.Craiel.Essentials.Contracts;
    using Assets.Scripts.Craiel.Essentials.Editor;
    using Assets.Scripts.Craiel.GameData.Editor;
    using Craiel.VFX.Editor;

    public class EssentialEditorConfig : IEssentialEditorConfig
    {
        // -------------------------------------------------------------------
        // Public
        // -------------------------------------------------------------------
        public void Configure()
        {
            SceneToolbar.RegisterWidget<SceneToolbarGameData>();
            SceneToolbar.RegisterWidget<SceneToolbarVFX>();
            SceneToolbar.RegisterWidget<SceneToolbarUtils>();
            SceneToolbar.RegisterWidget<SceneToolbarBuildGeneration>();
        }
    }
}