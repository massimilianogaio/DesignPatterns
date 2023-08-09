using System;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class BeesSpawner : MonoBehaviour, IClickControllerObserver
    {
        [SerializeField] private GameObject _beePrefab;
        [SerializeField] private int _initialNumOfBees = 3;
        [SerializeField] private float spawnDistance = 5f;
        [SerializeField] private ClickControllerSubject _clickController;
        private Camera _camera;
        void Start()
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

        private void SpawnBee()
        {
            Vector3 spawnPosition = _camera.transform.position + _camera.transform.forward * spawnDistance;
            var go = Instantiate(_beePrefab, spawnPosition, Quaternion.identity);
        }
        public void UpdateObserverState(Collider colliderClicked)
        {
            if (colliderClicked.GetComponent<BeeColliderHandler>())
                SpawnBee();
        }
    }
}