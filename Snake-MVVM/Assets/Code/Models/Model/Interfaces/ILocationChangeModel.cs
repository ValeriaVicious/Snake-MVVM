

namespace SnakeTheClassicGameOnMVVM
{
    public interface ILocationChangeModel
    {
        public float PreviousCoordinateY { get; }
        public float PreviousCoordinateX { get; }
        public float CurrentCoordinateY { get; }
        public float CurrentCoordinateX { get; }
    }
}
