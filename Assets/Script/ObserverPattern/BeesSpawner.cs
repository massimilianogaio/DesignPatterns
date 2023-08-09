using System;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class BeesSpawner : MonoBehaviour, IObserver
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

            _clickController.OnColliderClicked += OnColliderClicked;
        }

        private void OnDestroy()
        {
            _clickController.OnColliderClicked -= OnColliderClicked;
        }

        private void SpawnBee()
        {
            Vector3 spawnPosition = _camera.transform.position + _camera.transform.forward * spawnDistance;
            var go = Instantiate(_beePrefab, spawnPosition, Quaternion.identity);
            go.GetComponent<BeeColliderHandler>().Init(_clickController);
        }
        private void OnColliderClicked(Collider colliderClicked)
        {
            if (colliderClicked.GetComponent<BeeColliderHandler>())
                UpdateObserverState();
        }

        public void UpdateObserverState()
        {
            SpawnBee();
        }
    }
}