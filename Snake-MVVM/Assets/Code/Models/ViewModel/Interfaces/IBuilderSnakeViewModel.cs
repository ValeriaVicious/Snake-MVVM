using System;


namespace SnakeTheClassicGameOnMVVM
{
    public interface IBuilderSnakeViewModel
    {
        public event Action<ILocationViewModel> OnCreateSegmentEvent;
    }
}
