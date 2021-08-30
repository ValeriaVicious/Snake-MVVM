using System;


namespace SnakeTheClassicGameOnMVVM
{
    public interface ILocationViewModel
    {
        public ILocationModel LocationModel { get; }
        public void MoveTheSnake(float x, float y);
        public event Action<ILocationChangeModel> OnLocationChangeEvent;
    }
}
