using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace DesignPatterns.StateMachine
{
    [CreateAssetMenu(fileName = "PlayerMoveState", menuName = "ScriptableObjects/new PlayerMoveState")]
    public class PlayerMoveState : PlayerState
    {
        [SerializeField] private float _moveSpeed = 4;
        
        private NavMeshAgent _navMeshAgent;
        private Camera _camera;

        private string ClassName => nameof(PlayerMoveState);
        #region Override Methods
        public override void OnEnter(PlayerStateController playerStateController)
        {
            Debug.Log($"{ClassName}.{nameof(OnEnter)}()");
            playerStateController.PlayerAnimator.SetTrigger(nameof(PlayerMoveState));
            _navMeshAgent = playerStateController.NavMeshAgentPlayer;
            _camera = Camera.main;
        }
        public override void OnUpdate(PlayerStateController playerStateController)
        {
            MovePlayer();
        }
        public override void OnExit(PlayerStateController playerStateController)
        {
            Debug.Log($"{ClassName}.{nameof(OnExit)}()");
        }
        #endregion
        #region Private Methods
        private void MovePlayer()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

            if (moveDirection.magnitude >= 0.1f)
            {
                Vector3 moveVector = Quaternion.Euler(0f, _camera.transform.eulerAngles.y, 0f) * moveDirection;
                _navMeshAgent.Move(moveVector * _moveSpeed * Time.deltaTime);
            }
        }

        #endregion

    }
}