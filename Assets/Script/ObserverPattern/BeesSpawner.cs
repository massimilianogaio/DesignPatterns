using System;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class BeesSpawner : MonoBehaviour, IClickControllerObserver
    {
        #region Variables
        [Header("Spawner settings")]
        [SerializeField] private GameObject _beePrefab;
        [SerializeField] private int _initialNumOfBees = 3;
        [SerializeField] private float spawnDistance = 5f;
        [SerializeField] private float _maxDeviationSpawnDistance = 3f;
        [SerializeField] private ClickControllerSubject _clickController;
        private Camera _camera;
        #endregion
        #region MonoBehaviour Methods
        private void Start()
        {
            _camera = Camera.main;
            for (int i = 0; i < _initialNumOfBees; i++)
            {
                SpawnBee();
            }

            _clickController.OnColliderClicked += UpdateObserverState;
        }

        private void OnDestroy()
        {
            _clickController.OnColliderClicked -= UpdateObserverState;
        }
        #endregion
        #region Private Methods
        private void SpawnBee()
        {
            var initialPosition = new Vector3(
                UnityEngine.Random.Range(_camera.transform.position.x - _maxDeviationSpawnDistance, _camera.transform.position.x + _maxDeviationSpawnDistance),
                UnityEngine.Random.Range(_camera.transform.position.y - _maxDeviationSpawnDistance, _camera.transform.position.y + _maxDeviationSpawnDistance),
                _camera.transform.position.z);

            Vector3 spawnPosition = initialPosition + _camera.transform.forward * spawnDistance;
            var go = Instantiate(_beePrefab, spawnPosition, Quaternion.identity);
        }
        #endregion
        #region Interface Override Methods
        public void UpdateObserverState(Collider colliderClicked)
        {
            if (colliderClicked.GetComponent<BeeColliderIdentifier>())
                SpawnBee();
        }
        #endregion
    }
}