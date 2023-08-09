using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class BeeColliderHandler : MonoBehaviour, IObserver
    {
        private Collider _beeCollider;
        private ISubject _clickController;

        public void Init(ISubject clickController)
        {
            _beeCollider = GetComponent<Collider>();
            _clickController = clickController;

            _clickController.OnColliderClicked += OnColliderClicked;
        }

        private void OnDestroy()
        {
            _clickController.OnColliderClicked -= OnColliderClicked;
        }
        private void OnColliderClicked(Collider colliderClicked)
        {
            if (colliderClicked != _beeCollider) return;
            UpdateObserverState();
        }

        public void UpdateObserverState()
        {
            Destroy(gameObject);
        }
    }
}