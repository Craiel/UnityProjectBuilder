namespace Assets.Scripts.SetupCode
{
    using Craiel.Essentials;
    using Craiel.Essentials.Contracts;
    using Craiel.Essentials.Input;

    public class EssentialsConfig : IEssentialConfig
    {
        // -------------------------------------------------------------------
        // Public
        // -------------------------------------------------------------------
        public void Configure()
        {
            this.ConfigureInput();
        }

        // -------------------------------------------------------------------
        // Private
        // -------------------------------------------------------------------
        private void ConfigureInput()
        {
            EssentialsCore.DefaultInputState = InputStateDefault.Instance;
        }
    }
}
