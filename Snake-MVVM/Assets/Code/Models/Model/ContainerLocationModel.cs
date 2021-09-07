using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class ContainerLocationModel : IContainerLocation
    {
        #region Fields

        private List<ILocationViewModel> _locationViewModel;

        #endregion


        #region ClassLifeCycles

        public ContainerLocationModel()
        {
            _locationViewModel = new List<ILocationViewModel>();
        }

        #endregion


        #region Methods

        public void AddLocation(ILocationViewModel locationViewModel)
        {
            _locationViewModel.Add(locationViewModel);
        }

        public ILocationViewModel First()
        {
            return _locationViewModel.First();
        }

        public IEnumerator<ILocationViewModel> GetEnumerator()
        {
            return _locationViewModel.GetEnumerator();
        }

        public ILocationViewModel Last()
        {
            return _locationViewModel.Last();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _locationViewModel.GetEnumerator();
        }

        #endregion
    }
}
