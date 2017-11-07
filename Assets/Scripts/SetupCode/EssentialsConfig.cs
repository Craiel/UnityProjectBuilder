namespace Assets.Scripts.CoreGame
{
    using Craiel.Essentials;
    using Craiel.Essentials.Contracts;
    using Input;

    public class EssentialsConfig : IEssentialConfig
    {
        // -------------------------------------------------------------------
        // Public
        // -------------------------------------------------------------------
        public void Configure()
        {
            EssentialsCore.DefaultInputState = InputStates.Default;
        }
    }
}
