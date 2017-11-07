namespace Assets.Scripts.CoreGame
{
    using Craiel.Essentials;
    using Craiel.Essentials.Contracts;
    using Enums;
    using Input;

    public class EssentialsConfig : IEssentialConfig
    {
        // -------------------------------------------------------------------
        // Public
        // -------------------------------------------------------------------
        public void Configure()
        {
            EssentialsCore.DefaultInputState = InputStates.Default;
            EssentialsCore.InputControlType = typeof(Controls);
        }
    }
}
