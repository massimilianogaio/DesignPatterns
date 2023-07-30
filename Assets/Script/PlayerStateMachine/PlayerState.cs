using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.StateMachine
{
    public abstract class PlayerState : ScriptableObject
    {
        private string ClassName => nameof(PlayerState);
        public PlayerStateMachineCondition EnterCondition;
        public PlayerStateMachineCondition ExitCondition;

        public abstract void OnEnter(PlayerStateController playerStateController);
        public abstract void OnUpdate(PlayerStateController playerStateController);
        public abstract void OnExit(PlayerStateController playerStateController);

        public bool CheckEnterCondition(PlayerStateController playerStateController)
        {
            return EnterCondition.CheckCondition(playerStateController);
        }
        public bool CheckExitCondition(PlayerStateController playerStateController)
        {
            return ExitCondition.CheckCondition(playerStateController);
        }
    }
}
