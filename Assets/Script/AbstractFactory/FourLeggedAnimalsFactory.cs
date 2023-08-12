using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.AbstractFactory
{
    public class FourLeggedAnimalsFactory : MonoBehaviour, IAbstractAnimalFactory
    {
        #region Variables
        [Header("Four Legged Animals Prefabs")]
        [SerializeField] private GameObject _catPrefab;
        [SerializeField] private GameObject _lionPrefab;
        #endregion
        #region Factory Methods
        public GameObject CreateDomesticAnimal()
        {
            return _catPrefab;
        }

        public GameObject CreateWildAnimal()
        {
            return _lionPrefab;
        }
        #endregion
    }
}
