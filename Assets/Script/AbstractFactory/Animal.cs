using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.AbstractFactory
{
    public class Animal : MonoBehaviour, IAnimal
    {
        [SerializeField] private Vector3 _instantiationPosition;
        [SerializeField] private Quaternion _instantiationRotation;
        public Vector3 GetInstantiationPosition()
        {
            return _instantiationPosition;
        }

        public Quaternion GetInstantiationRotation()
        {
            return _instantiationRotation;
        }
    }
}