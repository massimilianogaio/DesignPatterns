using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace DesignPatterns.StateMachine
{
    public abstract class PlayerStateMachineCondition : ScriptableObject
    {
        [SerializeField] protected List<PlayerState> compatiblesStates;
        public abstract bool CheckCondition(PlayerStateController playerStateController);

        protected bool IsInCompatibleStates(PlayerState playerState)
        {
            return compatiblesStates.Where(state => state.GetType() == playerState.GetType()).FirstOrDefault() != null;
        }
    }
}
