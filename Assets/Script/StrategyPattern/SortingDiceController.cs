using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Strategy
{
    public class SortingDiceController : MonoBehaviour
    {
        [SerializeField] private List<DiceSide> _diceSides;
        [SerializeField] private SortingStrategy _sortingStrategy;
        void Start()
        {
            _sortingStrategy.SortDice(_diceSides);
        }
    }
}