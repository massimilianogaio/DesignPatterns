using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class ClickControllerObserver : MonoBehaviour, IClickControllerObserver
    {
        [SerializeField] private ClickControllerSubject _clickControllerSubject;

        public void Start()
        {

            _clickControllerSubject.OnColliderClicked += UpdateObserverState;
        }

        private void OnDestroy()
        {
            _clickControllerSubject.OnColliderClicked -= UpdateObserverState;
        }
        public void UpdateObserverState(Collider colliderClicked)
        {
            if(colliderClicked.TryGetComponent<BeeColliderHandler>(out var beeCollider))
            {
                Destroy(beeCollider.gameObject);
            }
        }
    }
}