namespace Assets.Scripts.CoreGame.Input
{
    using Craiel.Essentials.Contracts;
    using Craiel.Essentials.Input;
    
    public static class InputStates
    {
        public static readonly IInputState Default = new InputStateDefault();

        // -------------------------------------------------------------------
        // Constructor
        // -------------------------------------------------------------------
        static InputStates()
        {
            // Default mappings these are what the game starts with before we setup the correct state
            SetGlobalMappings(Default);
        }

        // -------------------------------------------------------------------
        // Private
        // -------------------------------------------------------------------
        private static void SetGlobalMappings(IInputState target)
        {
        }
    }
}
