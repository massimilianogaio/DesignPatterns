using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.SingletonCommandManger
{
    public class RockCommandDataInfo : MonoBehaviour
    {
        #region Variables
        [SerializeField] private Transform _targetTransform;
        public Transform TargetTransform => _targetTransform;
        #endregion
    }
}