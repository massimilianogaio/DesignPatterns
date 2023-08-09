using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.Observer
{
    public interface IClickControllerObserver
    {
        void UpdateObserverState(Collider collider);
    }
}