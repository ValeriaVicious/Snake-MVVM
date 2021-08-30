

namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class MoveTheSnakeViewModel
    {
        #region Fields

        private readonly ILocationViewModel _headOfSnakeLocation;
        private readonly IContainerLocation _snakeContainer;

        #endregion


        #region ClassLifeCycles

        public MoveTheSnakeViewModel(ILocationViewModel headOfSnakeLocation,
            IContainerLocation snakeContainer)
        {
            _headOfSnakeLocation = headOfSnakeLocation;
            _snakeContainer = snakeContainer;

            _headOfSnakeLocation.OnLocationChangeEvent += OnHeadChangeLocation;
        }

        ~MoveTheSnakeViewModel()
        {
            _headOfSnakeLocation.OnLocationChangeEvent -= OnHeadChangeLocation;
        }

        #endregion


        #region Methods

        private void OnHeadChangeLocation(ILocationChangeModel headOfSnakeLocation)
        {
            var previousX = headOfSnakeLocation.PreviousCoordinateX;
            var previousY = headOfSnakeLocation.PreviousCoordinateY;

            foreach (var segment in _snakeContainer)
            {
                if (segment != _snakeContainer.First())
                {
                    var previousBufferX = segment.LocationModel.X;
                    var previousBufferY = segment.LocationModel.Y;
                    segment.MoveTheSnake(previousX, previousBufferY);
                    previousX = previousBufferX;
                    previousY = previousBufferY;
                }
            }
        }

        #endregion
    }
}
