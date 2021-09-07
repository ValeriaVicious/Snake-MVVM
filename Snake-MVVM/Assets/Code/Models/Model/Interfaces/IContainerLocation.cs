using System.Collections.Generic;


namespace SnakeTheClassicGameOnMVVM
{
    public interface IContainerLocation : IEnumerable<ILocationViewModel>
    {
        public void AddLocation(ILocationViewModel locationViewModel);
        public ILocationViewModel First();
        public ILocationViewModel Last();
    }
}
