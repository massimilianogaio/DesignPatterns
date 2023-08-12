using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.ObjectComposition
{
    public class ChessForwardMovement : ChessMovement
    {
        #region Override Methods
        protected override Vector3 CalculatePawnPosition(Transform pawn)
        {
            return new Vector3(
                    pawn.transform.position.x,
                    pawn.transform.position.y,
                    Mathf.Min(pawn.transform.position.z + singleMovementDelta, maxBoardRangeZ)
                );
        }
        #endregion
    }
}