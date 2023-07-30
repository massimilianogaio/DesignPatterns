using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StateMachine
{
    public interface IPlayerState
    {
        public void OnEnter();
        public void OnUpdate();
        public void OnExit();
    }
}