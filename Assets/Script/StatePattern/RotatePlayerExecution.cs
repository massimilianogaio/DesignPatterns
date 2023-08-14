using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.StatePattern
{
    public class RotatePlayerExecution
    {
        #region Public Methods
        public void Execute(Transform playerTransform, float turnSpeed)
        {
            if (!Input.GetMouseButton(1)) return;

            float mouseX = Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime;
            Vector3 rotation = playerTransform.rotation.eulerAngles;
            rotation.y += mouseX;
            playerTransform.rotation = Quaternion.Euler(rotation);
        }
        #endregion
    }
}