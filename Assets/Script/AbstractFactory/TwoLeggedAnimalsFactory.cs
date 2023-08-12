using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.AbstractFactory
{
    public class TwoLeggedAnimalsFactory : MonoBehaviour, IAbstractAnimalFactory
    {
        #region Variables
        [Header("Two Legged Animals Prefabs")]
        [SerializeField] private GameObject _penguinPrefab;
        [SerializeField] private GameObject _chickenPrefab;
        #endregion
        #region Factory Methods
        public GameObject CreateDomesticAnimal()
        {
            return _chickenPrefab;
        }

        public GameObject CreateWildAnimal()
        {
            return _penguinPrefab;
        }
        #endregion
    }
}