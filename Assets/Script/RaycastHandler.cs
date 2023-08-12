using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DesignPatterns
{
    public sealed class RaycastHandler : MonoBehaviour
    {
        #region Variables
        public event Action<Collider> OnColliderClicked; 
        private RaycastHandler() { }
        private static RaycastHandler instance = null;
        private Camera _camera;
        #endregion

        #region Singleton Constructor
        public static RaycastHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    var go = new GameObject(nameof(RaycastHandler));
                    instance = go.AddComponent<RaycastHandler>();
                }
                return instance;
            }
        }
        #endregion
        #region MonoBehavior Methods
        private void Awake()
        {
            _camera = Camera.main;
        }
        private void Update()
        {
            if(Mouse.current.leftButton.wasPressedThisFrame)
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 100))
                {
                    OnColliderClicked.Invoke(hit.collider);
                }
            }
        }
        #endregion

    }
}