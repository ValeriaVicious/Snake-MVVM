

using System;

namespace SnakeTheClassicGameOnMVVM
{
    public interface ICommandViewModel
    {
        public event Action<MoveDirection> OnGetCommandEvent;
    }
}