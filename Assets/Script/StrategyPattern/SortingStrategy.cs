using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.Strategy
{
    public abstract class SortingStrategy : MonoBehaviour
    {
        protected DiceMovementController diceMovementController;

        protected struct DiceSideInfo
        {
            public int DotNumber;
            public Transform DiceTransform;
        }
        protected List<DiceSideInfo> diceSideInfos;
        private void Awake()
        {
            diceMovementController = gameObject.AddComponent<DiceMovementController>();
        }

        private void SetDiceInfos(List<DiceSide> diceSides)
        {
            diceSideInfos = new List<DiceSideInfo>();
            foreach (var side in diceSides)
            {
                diceSideInfos.Add(new DiceSideInfo { DotNumber = side.DotNumber, DiceTransform = side.transform}); 
            }
        }
        public void SortDice(List<DiceSide> diceSides)
        {
            SetDiceInfos(diceSides);
            PerformSorting();
        }
        protected abstract void PerformSorting();
    }
}