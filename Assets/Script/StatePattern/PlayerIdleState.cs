using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StatePattern
{
    [CreateAssetMenu(fileName = "PlayerIdleState", menuName = "ScriptableObjects/new PlayerIdleState")]
    public class PlayerIdleState : PlayerState
    {
        protected new string ClassName => nameof(PlayerIdleState);
        
        [SerializeField] private float _rotationSpeed = 10f;
        private RotatePlayerExecution _rotatePlayerExecution = new RotatePlayerExecution();
        public override void OnEnter(PlayerStateController playerStateController)
        {
            Debug.Log($"{ClassName}.{nameof(OnEnter)}()");
            playerStateController.PlayerAnimator.SetTrigger(nameof(PlayerIdleState));
        }
        public override void OnUpdate(PlayerStateController playerStateController)
        {
            _rotatePlayerExecution.Execute(playerStateController.transform, _rotationSpeed);

        }
        public override void OnExit(PlayerStateController playerStateController)
        {
            Debug.Log($"{ClassName}.{nameof(OnExit)}()");
        }
    }
}