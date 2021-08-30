using System;


namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class Timer
    {
        #region Fields

        private float _timeBeforeNextSpawn;
        private float _interval;

        public event Action OnTickTimerEvent;

        #endregion


        #region ClassLifeCycles

        public Timer(float timeBeforeNextSpawn, float interval)
        {
            _interval = interval;
            _timeBeforeNextSpawn = timeBeforeNextSpawn;
        }

        #endregion


        #region Methods

        public void StartTick(float deltaTime)
        {
            _timeBeforeNextSpawn -= deltaTime;

            if (_timeBeforeNextSpawn <= 0)
            {
                OnTickTimerEvent?.Invoke();
                _timeBeforeNextSpawn = _interval;
            }
        }

        #endregion
    }
}
