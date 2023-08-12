using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.SingletonCommandManger
{
    public class MoveCommand : ICommand
    {
        #region Variables
        private Transform _transformToMove;
        private Vector3 _previousPosition;
        private Vector3 _nextPosition;
        #endregion

        #region Public Methods
        public MoveCommand(Transform transformToMove, Vector3 previousPosition, Vector3 nextPosition)
        {
            _transformToMove = transformToMove;
            _previousPosition = previousPosition;
            _nextPosition = nextPosition;
        }
        public void Execute()
        {
            _transformToMove.position = _nextPosition;
        }

        public void Undo()
        {
            _transformToMove.position = _previousPosition;
        }
        #endregion
    }
}