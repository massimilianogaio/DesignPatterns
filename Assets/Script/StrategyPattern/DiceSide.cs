using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Strategy
{
    public class DiceSide : MonoBehaviour
    {
        [SerializeField, Range(1, 6)] private int _dotNumber;
        public int DotNumber => _dotNumber;
    }
}