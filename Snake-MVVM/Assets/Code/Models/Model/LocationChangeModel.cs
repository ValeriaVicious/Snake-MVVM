

namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class LocationChangeModel : ILocationChangeModel
    {
        #region Fields

        public float PreviousCoordinateY { get; }

        public float PreviousCoordinateX { get; }

        public float CurrentCoordinateY { get; }

        public float CurrentCoordinateX { get; }

        #endregion


        #region ClassLifeCycles

        public LocationChangeModel(float previousX, float previousY, float currentX, float currentY)
        {
            PreviousCoordinateY = previousY;
            PreviousCoordinateX = previousX;
            CurrentCoordinateY = currentY;
            CurrentCoordinateX = currentX;
        }

        #endregion
    }
}
