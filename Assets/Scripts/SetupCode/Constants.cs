namespace SetupCode
{
    using Assets.Scripts.Craiel.Essentials;
    using Assets.Scripts.Craiel.Essentials.IO;
    using Assets.Scripts.Craiel.Essentials.Resource;
    using UnityEngine;

    public static class Constants
    {
        public static readonly CarbonDirectory ResourcesPath = EssentialsCore.AssetsPath.ToDirectory(EssentialsCore.ResourcesFolderName);
        
        public const string GameDataFileName = "gamedata";
        public const string GameDataExtension = ".bytes";
        
        public static readonly CarbonFile GameDataDataFile = ResourcesPath.ToFile(GameDataFileName + GameDataExtension);
        public static readonly ResourceKey GameDataResourceKey = ResourceKey.Create<TextAsset>(GameDataDataFile.FileName);
    }
}