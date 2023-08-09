using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.AbstractFactory
{
    public enum EAnimalType
    {
        TwoLegged,
        FourLegged
    }
    public class ClientFactory : MonoBehaviour
    {
        [SerializeField] private EAnimalType _animalType;

        [SerializeField] private TwoLeggedAnimalsFactory _twoLeggedAnimalsFactory;
        [SerializeField] private FourLeggedAnimalsFactory _fourLeggedAnimalsFactory;

        private void Start()
        {
            var factoryToUse = GetFactory();

            if (factoryToUse == null)
            {
                Debug.LogError($"No factory assigned for {_animalType}");
                return;
            }
            CreateAnimals(factoryToUse);
        }

        private void CreateAnimals(IAbstractAnimalFactory factoryToUse)
        {
            InstantiateAnimal(factoryToUse.CreateDomesticAnimal());
            InstantiateAnimal(factoryToUse.CreateWildAnimal());
        }

        private void InstantiateAnimal(GameObject animal)
        {
            var animalController = animal.GetComponent<Animal>();
            Instantiate(animal, animalController.GetInstantiationPosition(), animalController.GetInstantiationRotation());
        }

        private IAbstractAnimalFactory GetFactory()
        {
            switch (_animalType)
            {
                case EAnimalType.TwoLegged:
                    return _twoLeggedAnimalsFactory;
                case EAnimalType.FourLegged:
                    return _fourLeggedAnimalsFactory;
                default:
                    return null;
            }
        }
    }
}