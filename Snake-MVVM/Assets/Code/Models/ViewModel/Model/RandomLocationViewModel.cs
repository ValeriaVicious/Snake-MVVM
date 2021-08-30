using System;


namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class RandomLocationViewModel : IRandomFoodLocationViewModel
    {
        #region Field

        private readonly ILocationCoordinates _locationCoordinates;
        public event Action<ILocationChangeModel> OnLocationChangeEvent;

        #endregion


        #region Properties

        public ILocationModel LocationModel { get; set; }

        #endregion


        #region ClassLifeCycles

        public RandomLocationViewModel(ILocationModel locationModel,
            ILocationCoordinates locationCoordinates)
        {
            LocationModel = locationModel;
            _locationCoordinates = locationCoordinates;
        }

        #endregion


        #region Methods

        public void ChangeTheLocation()
        {
            var previousX = LocationModel.X;
            var previousY = LocationModel.Y;

            LocationModel.X = UnityEngine.Random.Range(_locationCoordinates.MinX,
                _locationCoordinates.MaxX);
            LocationModel.Y = UnityEngine.Random.Range(_locationCoordinates.MinY,
                _locationCoordinates.MaxY);
            var locationChangeModel = new LocationChangeModel(previousX, previousY,
                LocationModel.X, LocationModel.Y);
            OnLocationChangeEvent?.Invoke(locationChangeModel);
        }

        #endregion
    }
}
