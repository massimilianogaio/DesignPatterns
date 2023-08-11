using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ObjectComposition
{
    public class ChessPiece : MonoBehaviour
    {
#nullable enable
        [SerializeField] private ChessAspect? _chessAspect;
#nullable disable
        [SerializeField] private List<ChessMovement> _chessMovements;
        private Camera _camera;

        void Awake()
        {
            _camera = Camera.main;
            
            _chessAspect?.SetChessAspect();
        }

        void Update()
        {
            if (!Input.GetMouseButtonDown(0)) return;
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.transform == transform)
                {
                    MoveChessPiece();
                }
            }
        }
        private void MoveChessPiece()
        {
            foreach(var move in _chessMovements)
            {
                var hasMoved = move.MoveChessPawn(transform);
                
                if (hasMoved)
                    return;
            }
        }
    }
}