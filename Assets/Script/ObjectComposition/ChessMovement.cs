using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.ObjectComposition
{
    public abstract class ChessMovement : MonoBehaviour
    {
        protected float maxBoardRangeX = 6f;
        protected float maxBoardRangeZ = 10f;
        protected float singleMovementDelta = 1.5f;

        public bool MoveChessPawn(Transform pawn)
        {
            if (HasReachedBoardLimit(pawn.transform.position)) return false;

            var newPos = CalculatePawnPosition(pawn);

            if (!IsChessBoxEmpty(newPos))
            {
                return false;
            }
            else
            {
                pawn.transform.position = newPos;
                return true;
            }     
            
        }
        protected abstract Vector3 CalculatePawnPosition(Transform pawn);
        protected bool HasReachedBoardLimit(Vector3 position)
        {
            return position.x + singleMovementDelta > maxBoardRangeX && position.z + singleMovementDelta > maxBoardRangeZ;
        }
        protected bool IsChessBoxEmpty(Vector3 position)
        {
            return Physics.OverlapSphere(position, 0.1f).Length == 0;
        }
        
    }
}