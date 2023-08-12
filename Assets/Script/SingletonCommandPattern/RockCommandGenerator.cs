using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DesignPatterns.SingletonCommandManger
{
    public class RockCommandGenerator : MonoBehaviour
    {
        #region Variables
        [SerializeField] Transform _player;
        private Camera _camera;
        #endregion
        #region MonoBehaviour Methods
        private void Start()
        {
            _camera = Camera.main;
            RaycastHandler.Instance.OnColliderClicked += OnColliderClicked;
        }

        private void OnDestroy()
        {
            RaycastHandler.Instance.OnColliderClicked -= OnColliderClicked;
        }
        void Update()
        {
            
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                CommandManager.Instance.PopCommand();
            }
        }
        #endregion

        #region Listeners Methods
        private void OnColliderClicked(Collider collider)
        {
            if (collider.TryGetComponent<RockCommandDataInfo>(out var rock))
            {
                var newCommand = new MoveCommand(_player, _player.position, rock.TargetTransform.position);
                CommandManager.Instance.PushCommand(newCommand);
            }
        }
        #endregion
    }
}