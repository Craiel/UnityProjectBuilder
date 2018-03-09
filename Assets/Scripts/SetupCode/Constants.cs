namespace Assets.Scripts.SetupCode
{
    using Craiel.Essentials;
    using Craiel.Essentials.IO;
    using Craiel.Essentials.Resource;
    using UnityEngine;

    public static class Constants
    {
        public static readonly CarbonDirectory ResourcesFolder = new CarbonDirectory(EssentialsCore.ResourcesFolderName);
        public static readonly CarbonDirectory ResourcesPath = EssentialsCore.AssetsPath.ToDirectory(ResourcesFolder);
        
        public const string GameDataFileName = "gamedata";
        public const string GameDataExtension = ".bytes";
        
        public static readonly CarbonFile GameDataDataFile = ResourcesPath.ToFile(GameDataFileName + GameDataExtension);
        public static readonly ResourceKey GameDataResourceKey = ResourceKey.Create<TextAsset>(GameDataFileName);
    }
}