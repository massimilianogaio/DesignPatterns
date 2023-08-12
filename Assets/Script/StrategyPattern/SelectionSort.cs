using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace DesignPatterns.Strategy
{
    public class SelectionSort : SortingStrategy
    {
        #region Override Methods
        protected override void PerformSorting()
        {
            SelectionSortAlgorithm(diceSideInfos);
        }
        #endregion
        #region Private Methods
        private void SelectionSortAlgorithm(List<DiceSideInfo> diceSideInfos)
        {
            var arrayLength = diceSideInfos.Count();
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (diceSideInfos[j].DotNumber < diceSideInfos[smallestVal].DotNumber)
                    {
                        smallestVal = j;
                    }
                }
                diceMovementController.EnqueueSwap(diceSideInfos[smallestVal].DiceTransform, diceSideInfos[i].DiceTransform);
                var tempVar = diceSideInfos[smallestVal];
                diceSideInfos[smallestVal] = diceSideInfos[i];
                diceSideInfos[i] = tempVar;
            }
        }
        #endregion
    }
}
