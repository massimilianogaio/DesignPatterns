using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.AbstractFactory
{
    public class TwoLeggedAnimalsFactory : MonoBehaviour, IAbstractAnimalFactory
    {
        [SerializeField] private GameObject _penguinPrefab;
        [SerializeField] private GameObject _chickenPrefab;
        public GameObject CreateDomesticAnimal()
        {
            return _chickenPrefab;
        }

        public GameObject CreateWildAnimal()
        {
            return _penguinPrefab;
        }
    }
}