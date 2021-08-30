using System;
using UnityEngine;


namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class CommandViewModel : ICommandViewModel, IExecute
    {
        #region Fields

        private readonly IRoundExecuteViewModel _roundExecuteViewModel;
        private MoveDirection _lastMoveDirection;
        public event Action<MoveDirection> OnGetCommandEvent;

        #endregion


        #region ClassLifeCycles

        public CommandViewModel(IRoundExecuteViewModel roundExecuteView)
        {
            _roundExecuteViewModel = roundExecuteView;
            _roundExecuteViewModel.OnNewRoundEvent += OnNewRound;
        }

        ~CommandViewModel()
        {
            _roundExecuteViewModel.OnNewRoundEvent -= OnNewRound;
        }

        #endregion


        #region Methods
        private void OnNewRound()
        {
            OnGetCommandEvent?.Invoke(_lastMoveDirection);
        }

        private void InputGetMove()
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                _lastMoveDirection = MoveDirection.Right;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _lastMoveDirection = MoveDirection.Left;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _lastMoveDirection = MoveDirection.Up;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                _lastMoveDirection = MoveDirection.Down;
            }
        }

        public void Execute(float deltaTime)
        {
            InputGetMove();
        }

        #endregion
    }
}
