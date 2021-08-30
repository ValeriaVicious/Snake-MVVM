using System;


namespace SnakeTheClassicGameOnMVVM
{
    public sealed class RoundExecuteViewModel : IRoundExecuteViewModel, IExecute
    {
        #region Fields

        public event Action OnNewRoundEvent;

        #endregion


        #region ClassLifeCycles
        #endregion


        #region Methods

        public void Execute(float deltaTime)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
