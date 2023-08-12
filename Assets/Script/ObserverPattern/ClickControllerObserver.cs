using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class ClickControllerObserver : MonoBehaviour, IClickControllerObserver
    {
        #region Variables
        [SerializeField] private ClickControllerSubject _clickControllerSubject;
        #endregion
        #region MonoBehaviour Methods
        public void Start()
        {
            _clickControllerSubject.OnColliderClicked += UpdateObserverState;
        }

        private void OnDestroy()
        {
            _clickControllerSubject.OnColliderClicked -= UpdateObserverState;
        }
        #endregion
        #region Interface Override Methods
        public void UpdateObserverState(Collider colliderClicked)
        {
            if(colliderClicked.TryGetComponent<BeeColliderIdentifier>(out var beeCollider))
            {
                Destroy(beeCollider.gameObject);
            }
        }
        #endregion
    }
}