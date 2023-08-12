using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Strategy
{
    public class SortingDiceController : MonoBehaviour
    {
        #region Variables
        [Header("Sorting settings")]
        [SerializeField] private List<DiceSide> _diceSides;
        [SerializeField] private SortingStrategy _sortingStrategy;
        #endregion
        #region MonoBehaviour Methods
        void Start()
        {
            if (_sortingStrategy == null)
            {
                Debug.LogWarning($"no value set on variable {nameof(_sortingStrategy)}, no sorting will be executed.");
                return;
            }
            _sortingStrategy.SortDice(_diceSides);
        }
        #endregion
    }
}