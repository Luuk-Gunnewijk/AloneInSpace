using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButton_Script : MonoBehaviour
{
    public Canvas myCanvas;

    public bool IsInteractButtonTrue;

    void Start()
    {
        myCanvas.enabled = false;
    }

    private void Update()
    {
        InteractButtonOn();
    }
    void InteractButtonOn()
    {
        if (IsInteractButtonTrue == true)
        {
            myCanvas.enabled = true;
        }
        else
        {
            myCanvas.enabled = false;
        }
        
    }
}
