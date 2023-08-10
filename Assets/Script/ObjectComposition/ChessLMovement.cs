using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.ObjectComposition
{
    public class ChessLMovement : ChessMovement
    {
        protected override Vector3 CalculatePawnPosition(Transform pawn)
        {
            var newX = pawn.transform.position.x + singleMovementDelta <= maxBoardRangeX ?
                        pawn.transform.position.x + singleMovementDelta :
                        pawn.transform.position.x - singleMovementDelta;

            return new Vector3(
                    Mathf.Min(newX, maxBoardRangeX),
                    pawn.transform.position.y,
                    Mathf.Min(pawn.transform.position.z + singleMovementDelta * 2, maxBoardRangeZ)
                );
        }
    }
}