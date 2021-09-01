using UnityEngine;
using System.Collections.Generic;


namespace SnakeTheClassicGameOnMVVM
{
    internal sealed class Starter : MonoBehaviour
    {
        #region Fields

        [SerializeField] private GameObject _segmentOfSnakePrefab;
        [SerializeField] private LocationView _headView;
        [SerializeField] private FoodView _foodView;

        private IList<IExecute> _executeObjects = new List<IExecute>();
        private float _locationOfTheHeadX = 0.5f;
        private float _locationOfTheHeadY = 0.5f;
        private float _randomExecuteView = 0.25f;
        private float _randomLocationOfModelX = 3.5f;
        private float _randomLocationOfModelY = 3.5f;
        private float _locationCoordinatesMinX = -20.0f;
        private float _locationCoordinatesMaxX = 20.0f;
        private float _locationCoordinatesMinY = -10.0f;
        private float _locationCoordinatesMaxY = 10.0f;

        #endregion


        #region UnityMethods

        private void Start()
        {
            var locationOfModel = new LocationModel(_locationOfTheHeadX, _locationOfTheHeadY);
            var roundExecuteViewModel = new RoundExecuteViewModel(_randomExecuteView);
            var commandViewModel = new CommandViewModel(roundExecuteViewModel);
            var randomLocationModel = new LocationModel(_randomLocationOfModelX, _randomLocationOfModelY);
            var locationCoordinates = new LocationCoordinates(_locationCoordinatesMinX,
                _locationCoordinatesMaxX, _locationCoordinatesMinY, _locationCoordinatesMaxY);
            var foodLocation = new RandomLocationViewModel(randomLocationModel,
                locationCoordinates);
            _executeObjects.Add(commandViewModel);
            _executeObjects.Add(roundExecuteViewModel);

            var headLocationViewModel = new LocationCommandViewModel(locationOfModel, commandViewModel);
            var segmentBuilderViewModel = new SegmentBuilderViewModel(_segmentOfSnakePrefab);
            var segmentContainerModel = new ContainerLocationModel();
            segmentContainerModel.AddLocation(headLocationViewModel);

            var snakeBuilderVM = new SnakeBuilderViewModel(segmentContainerModel, segmentBuilderViewModel, foodLocation);
            var snakeMoveVM = new MoveTheSnakeViewModel(segmentContainerModel, headLocationViewModel);
            _headView.Initialize(headLocationViewModel);
            _foodView.Initialize(foodLocation);
        }

        private void Update()
        {
            foreach (IExecute execute in _executeObjects)
            {
                execute.Execute(Time.deltaTime);
            }
        }

        #endregion

    }
}
