using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.AbstractFactory
{
    public interface IAnimal
    {
        Vector3 GetInstantiationPosition();
        Quaternion GetInstantiationRotation();
    }
}