using System;


namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class SnakeBuilderViewModel : IBuilderSnakeViewModel
    {
        #region Fields

        private readonly IContainerLocation _snakeSegmentContainer;
        private readonly IBuilderSegmentOfSnakeViewModel _segmentOfSnakeViewModel;
        private readonly IRandomFoodLocationViewModel _foodLocation;
        public event Action<ILocationViewModel> OnCreateSegmentEvent;

        #endregion


        #region ClassLifeCycles

        public SnakeBuilderViewModel(IContainerLocation snakeSegmentContainer,
            IBuilderSegmentOfSnakeViewModel builderSegmentOfSnake, IRandomFoodLocationViewModel randomFoodLocation)
        {
            _snakeSegmentContainer = snakeSegmentContainer;
            _segmentOfSnakeViewModel = builderSegmentOfSnake;
            _foodLocation = randomFoodLocation;

            _foodLocation.OnLocationChangeEvent += OnFoodLocationChange;
        }

        #endregion


        #region Methods

        private void OnFoodLocationChange(ILocationChangeModel locationChangeModel)
        {
            var lastSegment = _snakeSegmentContainer.Last();
            var newSegment = _segmentOfSnakeViewModel.CreateSegment(lastSegment.LocationModel.X,
                lastSegment.LocationModel.Y);
            _snakeSegmentContainer.AddLocation(newSegment);
            OnCreateSegmentEvent?.Invoke(newSegment);
        }

        #endregion
    }
}
