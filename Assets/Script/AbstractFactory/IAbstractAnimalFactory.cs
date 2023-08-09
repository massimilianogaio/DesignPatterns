using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.AbstractFactory
{
    public interface IAbstractAnimalFactory
    {
        GameObject CreateWildAnimal();
        GameObject CreateDomesticAnimal();
    }
}