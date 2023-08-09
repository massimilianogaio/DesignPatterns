using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
            if (!Input.GetMouseButtonDown(0)) return;

            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                OnColliderClicked?.Invoke(hit.collider);
            }
        }

    }
}