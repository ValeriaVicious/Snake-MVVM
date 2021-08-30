using UnityEngine;


namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class LocationView : MonoBehaviour
    {
        #region Fields

        private ILocationViewModel _locationViewModel;

        #endregion


        #region ClassLifeCycles

        ~LocationView()
        {
            _locationViewModel.OnLocationChangeEvent -= OnLocationChange;
        }

        #endregion


        #region Methods

        public void Initialize(ILocationViewModel locationViewModel)
        {
            _locationViewModel = locationViewModel;
            _locationViewModel.OnLocationChangeEvent += OnLocationChange;
        }

        private void OnLocationChange(ILocationChangeModel locationChangePosition)
        {
            transform.position = new Vector3(locationChangePosition.CurrentCoordinateX,
                locationChangePosition.CurrentCoordinateY, 0.0f);
        }

        #endregion
    }
}
