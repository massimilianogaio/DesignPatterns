using System;
using UnityEngine;
namespace DesignPatterns.Observer
{
    public interface ISubject
    {
        public event Action<Collider> OnColliderClicked;
    }
}