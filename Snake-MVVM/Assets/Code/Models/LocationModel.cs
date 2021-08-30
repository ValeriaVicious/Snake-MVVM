

namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class LocationModel : ILocationModel
    {
        #region Properties

        public float X { get; set; }
        public float Y { get; set; }

        #endregion


        #region ClassLifeCycles

        public LocationModel(float x, float y)
        {
            X = x;
            Y = y;
        }

        #endregion
    }
}
