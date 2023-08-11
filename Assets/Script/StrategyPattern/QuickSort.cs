using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace DesignPatterns.Strategy
{
    public class QuickSort : SortingStrategy
    {
        protected override void PerformSorting()
        {
            QuickSortFunction(diceSideInfos, 0, diceSideInfos.Count() - 1);
            var a = diceSideInfos;
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

        private void QuickSortFunction(List<DiceSideInfo> diceSideInfos, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(diceSideInfos, low, high);

                QuickSortFunction(diceSideInfos, low, pi - 1);
                QuickSortFunction(diceSideInfos, pi + 1, high);
            }
        }

        private void QuickSortAlgorithm(List<DiceSideInfo> diceSideInfos)
        {
            QuickSortFunction(diceSideInfos, 0, diceSideInfos.Count() - 1);
        }
    }
}
