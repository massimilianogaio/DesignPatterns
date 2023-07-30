using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

namespace DesignPatterns.StateMachine
{
    public class PlayerStateController : MonoBehaviour
    {
        [SerializeField] private List<PlayerState> _states;
        
        private PlayerState _currentState = null;
        #region State Machines Variables
        public PlayerState CurrentState => _currentState;
        public Vector3? TeleportDestination { get; set; }
        public Animator PlayerAnimator { get; private set; }
        public NavMeshAgent NavMeshAgentPlayer { get; private set; }
        #endregion
        private void Start()
        {
            if(_states.Count() == 0)
            {
                Debug.LogWarning($"No states found in {nameof(PlayerStateController)} on {gameObject.name}.");
                return;
            }

            NavMeshAgentPlayer = GetComponent<NavMeshAgent>();
            PlayerAnimator = GetComponentInChildren<Animator>();

            ChangeState(_states[0]);
        }
        void Update()
        {
            if (_currentState != null)
            {
                _currentState.OnUpdate(this);
            }
            CheckChangeState();
        }

        private void CheckChangeState()
        {
            foreach(var state in _states)
            {
                if(state != _currentState && state.CheckEnterCondition(this))
                {
                    ChangeState(state);
                }
            }
        }

        private void ChangeState(PlayerState newState)
        {
            if(_currentState != null)
            {
                _currentState.OnExit(this);
            }

            _currentState = newState;
            _currentState.OnEnter(this);
        }

    }
}