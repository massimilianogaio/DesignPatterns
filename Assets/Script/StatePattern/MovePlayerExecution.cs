using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace DesignPatterns.StatePattern
{
    public class MovePlayerExecution
    {
        #region Public Methods
        public void Execute(NavMeshAgent navMeshAgent, Camera camera, float moveSpeed)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

            if (moveDirection.magnitude >= 0.1f)
            {
                Vector3 moveVector = Quaternion.Euler(0f, camera.transform.eulerAngles.y, 0f) * moveDirection;
                navMeshAgent.Move(moveVector * moveSpeed * Time.deltaTime);
            }
        }
        #endregion
    }
}