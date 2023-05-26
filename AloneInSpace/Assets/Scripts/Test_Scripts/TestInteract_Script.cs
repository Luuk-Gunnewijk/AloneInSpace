using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteract_Script : MonoBehaviour
{
    InteractButton_Script myInteractButton_Script;

    private void Awake()
    {
        myInteractButton_Script = FindAnyObjectByType<InteractButton_Script>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && myInteractButton_Script.IsInteractButtonTrue == true)
        {
            gameObject.active = false;
        }
    }
}
