using System;


namespace SnakeTheClassicGameOnMVVM
{
    public sealed class RoundExecuteViewModel : IRoundExecuteViewModel, IExecute
    {
        #region Fields

        private readonly Timer _timer;
        public event Action OnNewRoundEvent;

        #endregion


        #region ClassLifeCycles

        public RoundExecuteViewModel(float interval)
        {
            _timer = new Timer(0.0f, interval);
            _timer.OnTickTimerEvent += OnTimerTick;
        }

        ~RoundExecuteViewModel()
        {
            _timer.OnTickTimerEvent -= OnTimerTick;
        }

        #endregion


        #region Methods

        public void Execute(float deltaTime)
        {
            _timer.StartTick(deltaTime);
        }

        private void OnTimerTick()
        {
            OnNewRoundEvent?.Invoke();
        }

        #endregion
    }
}
