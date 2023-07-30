using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StateMachine
{
    [CreateAssetMenu(fileName = "ExitTeleportStateCondition", menuName = "ScriptableObjects/new ExitTeleportStateCondition")]
    public class ExitTeleportStateCondition : PlayerStateMachineCondition
    {
        public override bool CheckCondition(PlayerStateController playerStateController)
        {
            //TODO: use new input system
            return IsInCompatibleStates(playerStateController.CurrentState) &&
                playerStateController.TeleportDestination == null;
        }
    }
}
