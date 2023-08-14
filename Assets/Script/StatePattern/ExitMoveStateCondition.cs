using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.StatePattern
{
    [CreateAssetMenu(fileName = "ExitMoveStateCondition", menuName = "ScriptableObjects/new ExitMoveStateCondition")]
    public class ExitMoveStateCondition : PlayerStateMachineCondition
    {
        public override bool CheckCondition(PlayerStateController playerStateController)
        {
            //TODO: use new input system
            return IsInCompatibleStates(playerStateController.CurrentState) &&
                !(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D));
        }
    }
}