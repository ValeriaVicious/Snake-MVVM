using System;


namespace SnakeTheClassicGameOnMVVM
{
    internal interface IRandomFoodLocationViewModel
    {
        public ILocationModel LocationModel { get; }
        public void ChangeTheLocation();
        public event Action<ILocationChangeModel> OnLocationChangeEvent;
    }
}
