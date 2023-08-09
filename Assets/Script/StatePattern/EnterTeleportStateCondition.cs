using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace DesignPatterns.StateMachine
{
    [CreateAssetMenu(fileName = "PlayerTeleportStateCondition", menuName = "ScriptableObjects/new PlayerTeleportStateCondition")]
    public class EnterTeleportStateCondition : PlayerStateMachineCondition
    {
        public override bool CheckCondition(PlayerStateController playerStateController)
        {
            if (!playerStateController.TeleportDestination.HasValue)
                return false;
            
            NavMeshPath path = new NavMeshPath();
            playerStateController.NavMeshAgentPlayer.CalculatePath(playerStateController.TeleportDestination.Value, path);

            return path.status == NavMeshPathStatus.PathComplete;
        }
    }
}