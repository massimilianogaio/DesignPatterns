using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessAspect : MonoBehaviour
{
    #region Variables
    [Header("Aspect settings")]
    [SerializeField] protected Renderer modelRenderer;
    [SerializeField] protected Material modeMaterial;
    #endregion
    #region Public Methods
    public void SetChessAspect()
    {
        modelRenderer.material = modeMaterial;
    }
    #endregion
}
