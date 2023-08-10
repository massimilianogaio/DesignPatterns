using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessAspect : MonoBehaviour
{
    [SerializeField] protected Renderer modelRenderer;
    [SerializeField] protected Material modeMaterial;
    public void SetChessAspect()
    {
        modelRenderer.material = modeMaterial;
    }
}
