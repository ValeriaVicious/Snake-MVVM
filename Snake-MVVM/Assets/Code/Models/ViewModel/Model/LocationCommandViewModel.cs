using System;


namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class LocationCommandViewModel : ILocationViewModel
    {
        #region Fields

        private readonly ICommandViewModel _command;

        public event Action<ILocationChangeModel> OnLocationChangeEvent;

        #endregion


        #region Properties

        public ILocationModel LocationModel { get; }

        #endregion


        #region ClassLifeCycles

        public LocationCommandViewModel(ILocationModel locationModel,
            ICommandViewModel commandViewModel)
        {
            LocationModel = locationModel;
            _command = commandViewModel;
            _command.OnGetCommandEvent += GetMoveCommand;
        }

        ~LocationCommandViewModel()
        {
            _command.OnGetCommandEvent -= GetMoveCommand;
        }

        #endregion


        #region Methods

        public void GetMoveCommand(MoveDirection moveDirection)
        {
            switch (moveDirection)
            {
                case MoveDirection.None:
                    break;
                case MoveDirection.Up:
                    LocationModel.Y++;
                    break;
                case MoveDirection.Down:
                    LocationModel.Y--;
                    break;
                case MoveDirection.Left:
                    LocationModel.X--;
                    break;
                case MoveDirection.Right:
                    LocationModel.X++;
                    break;
                default:
                    break;
            }
            MoveTheSnake(LocationModel.X, LocationModel.Y);
        }

        public void MoveTheSnake(float x, float y)
        {
            var locationChangeModel = new LocationChangeModel(LocationModel.X,
                LocationModel.Y, x, y);
            LocationModel.X = x;
            LocationModel.Y = y;
            OnLocationChangeEvent?.Invoke(locationChangeModel);
        }

        #endregion
    }
}
