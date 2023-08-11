using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace DesignPatterns.Strategy
{
    public class BubbleSort : SortingStrategy
    {
        protected override void PerformSorting()
        {
            BubbleSortAlgorithm(diceSideInfos);
            var a = diceSideInfos;
        }

        private void BubbleSortAlgorithm(List<DiceSideInfo> diceSideInfos)
        {
            int n = diceSideInfos.Count();
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (diceSideInfos[j].DotNumber > diceSideInfos[j + 1].DotNumber)
                    {
                        diceMovementController.EnqueueSwap(diceSideInfos[j].DiceTransform, diceSideInfos[j + 1].DiceTransform);
                        var temp = diceSideInfos[j];
                        diceSideInfos[j] = diceSideInfos[j + 1];
                        diceSideInfos[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
    }
}
