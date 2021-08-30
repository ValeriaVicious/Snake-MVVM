

namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class LocationCoordinates : ILocationCoordinates
    {
        #region Properties
        public float MinX { get; set; }
        public float MaxX { get; set; }
        public float MinY { get; set; }
        public float MaxY { get; set; }

        #endregion


        #region ClassLifeCycles

        public LocationCoordinates(float minX, float maxX, float minY, float maxY)
        {
            MinX = minX;
            MaxX = maxX;
            MinY = minY;
            MaxY = maxY;
        }

        #endregion
    }
}
