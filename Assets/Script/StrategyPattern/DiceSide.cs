using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StrategyPatternFactoryMethod
{
    public class DiceSide : MonoBehaviour
    {
        #region Variables
        [Tooltip("The number of dots that the side of the dice has.")]
        [SerializeField, Range(1, 6)] private int _dotNumber;
        public int DotNumber => _dotNumber;
        #endregion
    }
}