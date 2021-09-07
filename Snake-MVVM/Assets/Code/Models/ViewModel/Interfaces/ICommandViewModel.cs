using System;


namespace SnakeTheClassicGameOnMVVM
{
    internal interface ICommandViewModel
    {
        public event Action<MoveDirection> OnGetCommandEvent;
    }
}