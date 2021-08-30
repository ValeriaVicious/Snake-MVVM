using System;


namespace SnakeTheClassicGameOnMVVM
{
    internal interface IRoundExecuteViewModel
    {
        public event Action OnNewRoundEvent;
    }
}
