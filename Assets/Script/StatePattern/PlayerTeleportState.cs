using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.StatePattern
{
    [CreateAssetMenu(fileName = "PlayerTeleportState", menuName = "ScriptableObjects/new PlayerTeleportState")]
    public class PlayerTeleportState : PlayerState
    {
        protected new string ClassName => nameof(PlayerTeleportState);
        public override void OnEnter(PlayerStateController playerStateController)
        {
            Debug.Log($"{ClassName}.{nameof(OnEnter)}()");
            playerStateController.PlayerAnimator.SetTrigger(nameof(PlayerTeleportState));
            playerStateController.NavMeshAgentPlayer.SetDestination(playerStateController.TeleportDestination.Value);
        }
        public override void OnUpdate(PlayerStateController playerStateController)
        {
            var navMeshAgent = playerStateController.NavMeshAgentPlayer;
            if (!navMeshAgent.pathPending && navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
            {
                playerStateController.TeleportDestination = null;
            }
        }
        public override void OnExit(PlayerStateController playerStateController)
        {
            Debug.Log($"{ClassName}.{nameof(OnExit)}()");
            playerStateController.NavMeshAgentPlayer.ResetPath();
        }
    }
}