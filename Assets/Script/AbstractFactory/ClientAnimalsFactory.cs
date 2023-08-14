using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.AbstractFactory
{
    public class ClientAnimalsFactory : MonoBehaviour
    {
        #region Variables
        [Header("Factory settings")]
        [SerializeField] private TwoLeggedAnimalsFactory _twoLeggedAnimalsFactory;
        [SerializeField] private FourLeggedAnimalsFactory _fourLeggedAnimalsFactory;
        #endregion

        #region Public Methods
        public void InstantiateDomesticAnimal(EAnimalType eAnimalType)
        {
            var factoryToUse = GetFactory(eAnimalType);
            InstantiateAnimal(factoryToUse.CreateDomesticAnimal());
        }
        public void InstantiateWildAnimal(EAnimalType eAnimalType)
        {
            var factoryToUse = GetFactory(eAnimalType);
            InstantiateAnimal(factoryToUse.CreateWildAnimal());
        }
        #endregion
        #region Private Methods
        private void InstantiateAnimal(GameObject animal)
        {
            var animalController = animal.GetComponent<Animal>();
            Instantiate(animal, animalController.GetInstantiationPosition(), animalController.GetInstantiationRotation());
        }

        private IAbstractAnimalFactory GetFactory(EAnimalType eAnimalType)
        {
            switch (eAnimalType)
            {
                case EAnimalType.TwoLegged:
                    return _twoLeggedAnimalsFactory;
                case EAnimalType.FourLegged:
                    return _fourLeggedAnimalsFactory;
                default:
                    return null;
            }
        }
        #endregion
    }
}