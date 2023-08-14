using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StrategyPatternFactoryMethod
{
    public class SortingDiceController : MonoBehaviour
    {
        #region Variables
        [Header("Sorting settings")]
        [SerializeField] private List<DiceSide> _diceSides;

        private bool _isSorted = false;
        #endregion
        #region Public Methods
        public void StartSorting(Type sortingStrategyType)
        {
            if(_isSorted)
            {
                Debug.LogWarning($"Dice already sorted, reset the position before running a sorting strategy.");
                return;
            }

            var sortingStrategy = CreateSortingStrategy(sortingStrategyType);
            if (sortingStrategy == null)
            {
                Debug.LogWarning($"type {sortingStrategyType} not supported.");
                return;
            }
            sortingStrategy.SortDice(_diceSides);
            _isSorted = true;
        }
        #endregion
        #region Factory Method
        private SortingStrategy CreateSortingStrategy(Type sortingStrategyType)
        {
            Component strategy;
            if (sortingStrategyType.IsSubclassOf(typeof(SortingStrategy)))
            {
                strategy = gameObject.AddComponent(sortingStrategyType);
                return strategy as SortingStrategy;
            }
            return null;
        }
        #endregion
    }
}