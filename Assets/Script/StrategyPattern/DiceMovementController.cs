using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.Strategy
{
    public class DiceMovementController : MonoBehaviour
    {
        #region Variables
        private readonly Queue<IEnumerator> _queue = new Queue<IEnumerator>();
        private bool _isRunning;
        #endregion
        #region Public Methods
        public void EnqueueSwap(Transform t1, Transform t2)
        {
            _queue.Enqueue(SwapDiceTransforms(t1, t2));
            if (!_isRunning)
            {
                StartCoroutine(DoNext());
            }
        }
        #endregion
        #region Private Methods
        private IEnumerator DoNext()
        {
            if (_queue.Count == 0)
                yield break;

            _isRunning = true;

            yield return StartCoroutine(_queue.Dequeue());

            _isRunning = false;
            StartCoroutine(DoNext());
        }
        
        private IEnumerator SwapDiceTransforms(Transform transform1, Transform transform2)
        {
            var elapsedTime = 0f;
            var duration = 1f;
            var tempPos = transform1.position;

            Vector3 initialPos1 = transform1.position;
            Vector3 targetPos1 = transform2.position;

            while (elapsedTime < duration)
            {
                transform1.position = Vector3.Lerp(initialPos1, targetPos1, elapsedTime / duration);
                transform2.position = Vector3.Lerp(targetPos1, tempPos, elapsedTime / duration);

                elapsedTime += Time.deltaTime;
                yield return null;
            }
        }
        #endregion
    }
}
