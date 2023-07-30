using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StateMachine
{
    [CreateAssetMenu(fileName = "EnterMoveStateCondition", menuName = "ScriptableObjects/new EnterMoveStateCondition")]
    public class EnterMoveStateCondition : PlayerStateMachineCondition
    {
        public override bool CheckCondition(PlayerStateController playerStateController)
        {
            return (playerStateController.CurrentState == null || IsInCompatibleStates(playerStateController.CurrentState))
                && playerStateController.CurrentState.CheckExitCondition(playerStateController);


        }
    }
}
