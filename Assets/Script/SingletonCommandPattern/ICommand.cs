using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.SingletonCommandManger
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}