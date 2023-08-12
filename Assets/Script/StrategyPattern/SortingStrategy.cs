using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.Strategy
{
    public abstract class SortingStrategy : MonoBehaviour
    {
        #region Variables
        protected struct DiceSideInfo
        {
            public int DotNumber;
            public Transform DiceTransform;
        }

        protected DiceMovementController diceMovementController;
        protected List<DiceSideInfo> diceSideInfos;
        #endregion

        #region Abstract Method
        protected abstract void PerformSorting();
        #endregion
        #region Public Methods
        public void SortDice(List<DiceSide> diceSides)
        {
            InitSortingStrategy(diceSides);
            PerformSorting();
        }
        #endregion
        #region Private Methods
        private void InitSortingStrategy(List<DiceSide> diceSides)
        {
            diceMovementController = gameObject.AddComponent<DiceMovementController>();
            diceSideInfos = new List<DiceSideInfo>();
            foreach (var side in diceSides)
            {
                diceSideInfos.Add(new DiceSideInfo { DotNumber = side.DotNumber, DiceTransform = side.transform}); 
            }
        }
        #endregion

    }
}