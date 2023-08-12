using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ObjectComposition
{
    public class ChessPiece : MonoBehaviour
    {
        #region Variables
        [Header("Compositions features")]
#nullable enable
        [SerializeField] private ChessAspect? _chessAspect;
#nullable disable
        [SerializeField] private List<ChessMovement> _chessMovements;
        #endregion
        #region MonoBehaviour Methods
        void Awake()
        {   
            _chessAspect?.SetChessAspect();
            RaycastHandler.Instance.OnColliderClicked += OnColliderClicked;
        }

        private void OnDestroy()
        {
            RaycastHandler.Instance.OnColliderClicked -= OnColliderClicked;
        }
        #endregion
        #region Private Methods
        private void MoveChessPiece()
        {
            foreach(var move in _chessMovements)
            {
                var hasMoved = move.MoveChessPawn(transform);
                
                if (hasMoved)
                    return;
            }
        }
        #endregion
        #region Listeners Methods
        private void OnColliderClicked(Collider collider)
        {
            if (collider.transform == transform)
            {
                MoveChessPiece();
            }
        }
        #endregion
    }
}