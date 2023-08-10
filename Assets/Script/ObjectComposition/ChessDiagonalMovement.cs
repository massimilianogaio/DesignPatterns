using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.ObjectComposition
{
    public class ChessDiagonalMovement : ChessMovement
    {
        protected override Vector3 CalculatePawnPosition(Transform pawn)
        {
             return new Vector3(
                    Mathf.Min(pawn.transform.position.x + singleMovementDelta, maxBoardRangeX),
                    pawn.transform.position.y,
                    Mathf.Min(pawn.transform.position.z + singleMovementDelta, maxBoardRangeZ)
                );
        }
    }
}