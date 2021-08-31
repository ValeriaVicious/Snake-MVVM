using UnityEngine;


namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class FoodView : MonoBehaviour
    {
        #region Fields

        private IRandomFoodLocationViewModel _randomFoodLocationView;

        #endregion


        #region ClassLifeCycles

        ~FoodView()
        {
            _randomFoodLocationView.OnLocationChangeEvent -= OnLocationChange;
        }

        #endregion


        #region UnityMethods

        private void OnTriggerEnter2D(Collider2D collision)
        {
            _randomFoodLocationView.ChangeTheLocation();
        }

        #endregion


        #region Methods

        private void OnLocationChange(ILocationChangeModel locationChange)
        {
            transform.position = new Vector3(locationChange.CurrentCoordinateX,
                locationChange.CurrentCoordinateY, 0.0f);
        }

        public void Initialize(IRandomFoodLocationViewModel locationViewModel)
        {
            _randomFoodLocationView = locationViewModel;
            _randomFoodLocationView.OnLocationChangeEvent += OnLocationChange;
        }

        #endregion
    }
}
