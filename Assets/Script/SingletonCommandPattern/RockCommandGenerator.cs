using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.SingletonCommandManger
{
    public class RockCommandGenerator : MonoBehaviour
    {
        [SerializeField] Transform _player;
        private Camera _camera;
        
        private void Start()
        {
            _camera = Camera.main;
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                CommandManager.Instance.PopCommand();
            }

            if (!Input.GetMouseButtonDown(0)) return;
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.TryGetComponent<RockCommandDataInfo>(out var rock))
                {
                    var newCommand = new MoveCommand(_player, _player.position, rock.TargetTransform.position);
                    CommandManager.Instance.PushCommand(newCommand);
                }
            }


        }
    }
}