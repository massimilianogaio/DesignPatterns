using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace DesignPatterns.StatePattern
{
    [CreateAssetMenu(fileName = "PlayerMoveState", menuName = "ScriptableObjects/new PlayerMoveState")]
    public class PlayerMoveState : PlayerState
    {
        protected new string ClassName => nameof(PlayerMoveState);

        [SerializeField] private float _moveSpeed = 4f;
        [SerializeField] private float _rotationSpeed = 15f;

        private MovePlayerExecution _movePlayerExecution = new MovePlayerExecution();
        private RotatePlayerExecution _rotatePlayerExecution = new RotatePlayerExecution();

        private NavMeshAgent _navMeshAgent;
        private Camera _camera;

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
            _movePlayerExecution.Execute(_navMeshAgent, _camera, _moveSpeed);
            _rotatePlayerExecution.Execute(playerStateController.transform, _rotationSpeed);
        }
        public override void OnExit(PlayerStateController playerStateController)
        {
            Debug.Log($"{ClassName}.{nameof(OnExit)}()");
        }
        #endregion
    }
}