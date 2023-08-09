using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.AbstractFactory
{
    public class FourLeggedAnimalsFactory : MonoBehaviour, IAbstractAnimalFactory
    {
        [SerializeField] private GameObject _catPrefab;
        [SerializeField] private GameObject _lionPrefab;
        public GameObject CreateDomesticAnimal()
        {
            return _catPrefab;
        }

        public GameObject CreateWildAnimal()
        {
            return _lionPrefab;
        }
    }
}
