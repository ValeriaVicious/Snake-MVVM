using System;


namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class SegmentLocationViewModel : ILocationViewModel
    {
        #region Fields

        public event Action<ILocationChangeModel> OnLocationChangeEvent;

        #endregion


        #region Properties

        public ILocationModel LocationModel { get; }

        #endregion


        #region ClassLifeCycles

        public SegmentLocationViewModel(ILocationModel locationModel)
        {
            LocationModel = locationModel;
        }

        #endregion


        #region Methods

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
