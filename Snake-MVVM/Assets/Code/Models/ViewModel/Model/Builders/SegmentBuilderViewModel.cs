using UnityEngine;


namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class SegmentBuilderViewModel : IBuilderSegmentOfSnakeViewModel
    {
        #region Fields

        private readonly GameObject _segmentPrefab;

        #endregion


        #region ClassLifeCycles

        public SegmentBuilderViewModel(GameObject segment)
        {
            _segmentPrefab = segment;
        }

        #endregion


        #region Methods

        public ILocationViewModel CreateSegment(float x, float y)
        {
            var locationModel = new LocationModel(x, y);
            var locationViewModel = new SegmentLocationViewModel(locationModel);
            var segmentObject = Object.Instantiate(_segmentPrefab);
            var locationView = segmentObject.AddComponent<LocationView>();
            locationView.Initialize(locationViewModel);
            return locationViewModel;
        }

        #endregion
    }
}
