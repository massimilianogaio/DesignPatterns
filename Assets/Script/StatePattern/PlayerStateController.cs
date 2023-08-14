using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

namespace DesignPatterns.StatePattern
{
    public class PlayerStateController : MonoBehaviour
    {
        #region State Machines Variables
        [Tooltip("List of states supported.")]
        [SerializeField] private List<PlayerState> _states;

        private PlayerState _currentState = null;
        public PlayerState CurrentState => _currentState;
        public Vector3? TeleportDestination { get; set; }
        public Animator PlayerAnimator { get; private set; }
        public NavMeshAgent NavMeshAgentPlayer { get; private set; }
        #endregion
        #region MonoBehaviour
        private void Start()
        {
            if(_states.Count() == 0)
            {
                Debug.LogWarning($"No states found in {nameof(PlayerStateController)} on {gameObject.name}.");
                return;
            }

            NavMeshAgentPlayer = GetComponent<NavMeshAgent>();
            PlayerAnimator = GetComponentInChildren<Animator>();

            EnableState(_states[0]);
        }
        void Update()
        {
            if (_currentState != null)
            {
                _currentState.OnUpdate(this);
            }
            CheckChangeState();
        }
        #endregion
        #region Private Methods
        private void CheckChangeState()
        {
            foreach(var state in _states)
            {
                if(state != _currentState && state.CheckEnterCondition(this))
                {
                    EnableState(state);
                }
            }
        }

        private void EnableState(PlayerState newState)
        {
            if(_currentState != null)
            {
                _currentState.OnExit(this);
            }

            _currentState = newState;
            _currentState.OnEnter(this);
        }
        #endregion
    }
}