using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace DesignPatterns.Strategy
{
    public class InsertionSort : SortingStrategy
    {
        #region Override Methods
        protected override void PerformSorting()
        {
            InsertionSortAlgorithm(diceSideInfos);
        }
        #endregion
        #region Private Methods
        private void InsertionSortAlgorithm(List<DiceSideInfo> diceSideInfos)
        {
            for (int i = 0; i < diceSideInfos.Count() - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (diceSideInfos[j - 1].DotNumber > diceSideInfos[j].DotNumber)
                    {
                        diceMovementController.EnqueueSwap(diceSideInfos[j - 1].DiceTransform, diceSideInfos[j].DiceTransform);

                        var temp = diceSideInfos[j - 1];
                        diceSideInfos[j - 1] = diceSideInfos[j];
                        diceSideInfos[j] = temp;
                    }
                }
            }
        }
        #endregion
    }
}