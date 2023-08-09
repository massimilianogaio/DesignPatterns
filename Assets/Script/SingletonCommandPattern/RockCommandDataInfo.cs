using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.SingletonCommandManger
{
    public class RockCommandDataInfo : MonoBehaviour
    {
        [SerializeField] private Transform _targetTransform;
        public Transform TargetTransform => _targetTransform;
    }
}