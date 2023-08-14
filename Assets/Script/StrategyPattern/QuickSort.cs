using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace DesignPatterns.StrategyPatternFactoryMethod
{
    public class QuickSort : SortingStrategy
    {
        #region Override Methods
        protected override void PerformSorting()
        {
            QuickSortAlgorithm(diceSideInfos, 0, diceSideInfos.Count() - 1);
        }
        #endregion
        #region Private Methods
        private void QuickSortAlgorithm(List<DiceSideInfo> diceSideInfos, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(diceSideInfos, low, high);

                QuickSortAlgorithm(diceSideInfos, low, pi - 1);
                QuickSortAlgorithm(diceSideInfos, pi + 1, high);
            }
        }
        private int Partition(List<DiceSideInfo> diceSideInfos, int low, int high)
        {
            int pivot = diceSideInfos[high].DotNumber;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (diceSideInfos[j].DotNumber < pivot)
                {
                    i++;

                    diceMovementController.EnqueueSwap(diceSideInfos[i].DiceTransform, diceSideInfos[j].DiceTransform);
                    
                    var temp = diceSideInfos[i];
                    diceSideInfos[i] = diceSideInfos[j];
                    diceSideInfos[j] = temp;
                }
            }
            diceMovementController.EnqueueSwap(diceSideInfos[i + 1].DiceTransform, diceSideInfos[high].DiceTransform);

            var temp2 = diceSideInfos[i + 1];
            diceSideInfos[i + 1] = diceSideInfos[high];
            diceSideInfos[high] = temp2;

            return i + 1;
        }
        #endregion
    }
}
