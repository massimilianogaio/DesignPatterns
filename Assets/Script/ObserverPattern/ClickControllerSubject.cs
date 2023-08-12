using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DesignPatterns.Observer
{
    public class ClickControllerSubject : MonoBehaviour, ISubject
    {
        public event Action<Collider> OnColliderClicked;

        private Camera _camera;
        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (!Mouse.current.leftButton.wasPressedThisFrame) return;

            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                OnColliderClicked?.Invoke(hit.collider);
            }
        }

    }
}