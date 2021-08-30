

namespace SnakeTheClassicGameOnMVVM
{
    public interface IBuilderSegmentOfSnakeViewModel
    {
        public ILocationViewModel CreateSegment(float x, float y);
    }
}
