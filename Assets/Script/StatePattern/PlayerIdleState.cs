using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StateMachine
{
    [CreateAssetMenu(fileName = "PlayerIdleState", menuName = "ScriptableObjects/new PlayerIdleState")]
    public class PlayerIdleState : PlayerState
    {
        private string ClassName => nameof(PlayerIdleState);
        
        [SerializeField] private float _turnSpeed = 10;

        public override void OnEnter(PlayerStateController playerStateController)
        {
            Debug.Log($"{ClassName}.{nameof(OnEnter)}()");
            playerStateController.PlayerAnimator.SetTrigger(nameof(PlayerIdleState));
        }
        public override void OnUpdate(PlayerStateController playerStateController)
        {
            RotateCharacter(playerStateController);

        }
        public override void OnExit(PlayerStateController playerStateController)
        {
            Debug.Log($"{ClassName}.{nameof(OnExit)}()");
        }
        private void RotateCharacter(PlayerStateController playerStateController)
        {
            if (!Input.GetMouseButton(1)) return;

            float mouseX = Input.GetAxis("Mouse X") * _turnSpeed * Time.deltaTime;
            Vector3 rotation = playerStateController.transform.rotation.eulerAngles;
            rotation.y += mouseX;
            playerStateController.transform.rotation = Quaternion.Euler(rotation);
        }
    }
}