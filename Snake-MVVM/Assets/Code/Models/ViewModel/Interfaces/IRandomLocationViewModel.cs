using System;


namespace SnakeTheClassicGameOnMVVM
{
    internal interface IRandomLocationViewModel
    {
        public ILocationModel LocationModel { get; }
        public void ChangeTheLocation();
        public event Action<ILocationChangeModel> OnLocationChangeEvent;
    }
}
