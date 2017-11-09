namespace SetupCode
{
    using Assets.Scripts.Craiel.Essentials;
    using Assets.Scripts.Craiel.Essentials.IO;
    using Assets.Scripts.Craiel.Essentials.Resource;
    using UnityEngine;

    public static class Constants
    {
        public static readonly CarbonDirectory ResourcesFolder = new CarbonDirectory(EssentialsCore.ResourcesFolderName);
        public static readonly CarbonDirectory ResourcesPath = EssentialsCore.AssetsPath.ToDirectory(ResourcesFolder);
        
        public const string GameDataFileName = "gamedata";
        public const string GameDataExtension = ".bytes";
        
        public const int LogFileArchiveSize = 10485760;
        public const int LogFileArchiveCount = 10;
        
        
        public static readonly CarbonFile GameDataDataFile = ResourcesPath.ToFile(GameDataFileName + GameDataExtension);
        public static readonly ResourceKey GameDataResourceKey = ResourceKey.Create<TextAsset>(GameDataFileName);
    }
}