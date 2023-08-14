using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace DesignPatterns.StatePattern
{
    public class TeleportPlayerHandler : MonoBehaviour
    {
        #region Variable
        [SerializeField] PlayerStateController _playerStateController;
        #endregion
        #region MonoBehaviour Methods
        private void Start()
        {
            RaycastHandler.Instance.OnColliderClicked += OnColliderClicked;
        }

        private void OnDestroy()
        {
            if (RaycastHandler.Instance)
            {
                RaycastHandler.Instance.OnColliderClicked -= OnColliderClicked;
            }
        }
        #endregion
        #region Private Methods
        private void OnColliderClicked(Collider collider, Vector3 hitPoint)
        {
            if (collider.gameObject.layer == NavMesh.GetAreaFromName("Walkable"))
            {
                _playerStateController.TeleportDestination = hitPoint;
            }
        }
        #endregion
    }
}