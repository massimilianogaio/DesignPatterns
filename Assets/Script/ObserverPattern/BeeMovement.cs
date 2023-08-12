using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.Observer
{
    public class BeeMovement : MonoBehaviour
    {
        #region Variable
        [Header("Movement settings")]
        [SerializeField] private float _moveSpeed = 2f;
        [SerializeField] private float _maxDeviation = 2f;
        [SerializeField] private float _distance = 5f;
        
        private Vector3 targetPosition;
        private Camera _camera;
        #endregion

        #region MonoBehaviour Methods
        void Awake()
        {
            _camera = Camera.main;
        }
        private void Start()
        {
            targetPosition = GetRandomDeviation();
        }

        void Update()
        {
            MoveBee();
        }
        #endregion
        #region Private Methods
        private void MoveBee()
        {
            Vector3 direction = targetPosition - transform.position;
            transform.Translate(direction.normalized * _moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                targetPosition = GetRandomDeviation();
            }
        }

        private Vector3 GetRandomDeviation()
        {
            Vector3 deviation = new Vector3(Random.Range(-_maxDeviation, _maxDeviation), Random.Range(-_maxDeviation, _maxDeviation), 0f);
            return _camera.transform.position + _camera.transform.forward * _distance + deviation;
        }
        #endregion
    }
}