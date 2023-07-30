using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StateMachine
{
    [CreateAssetMenu(fileName = "EnterIdleStateCondition", menuName = "ScriptableObjects/new EnterIdleStateCondition")]
    public class EnterIdleStateCondition : PlayerStateMachineCondition
    {
        public override bool CheckCondition(PlayerStateController playerStateController)
        {
            return (playerStateController.CurrentState == null || IsInCompatibleStates(playerStateController.CurrentState)) 
                && playerStateController.CurrentState.CheckExitCondition(playerStateController);


        }
    }
}