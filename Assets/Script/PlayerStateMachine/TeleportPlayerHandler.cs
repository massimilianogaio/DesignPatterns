using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace DesignPatterns.StateMachine
{
    public class TeleportPlayerHandler : MonoBehaviour
    {
        [SerializeField] PlayerStateController _playerStateController;
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.layer == NavMesh.GetAreaFromName("Walkable"))
                    {
                        _playerStateController.TeleportDestination = hit.point;
                    }
                }
            }
        }
    }
}