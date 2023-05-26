using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast_Script : MonoBehaviour
{
    InteractButton_Script myInteractButton_Script;

    [SerializeField] LayerMask myLayerMask;
    RaycastHit hitinfo;

    private void Awake()
    {
        myInteractButton_Script = FindAnyObjectByType<InteractButton_Script>();
    }
    void Update()
    {
        Raycast();
    }

    void Raycast()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitinfo, 20f, myLayerMask))
        {
            myInteractButton_Script.IsInteractButtonTrue = true;

            //Debug.DrawRay(transform.position, transform.TransformDirection (Vector3.forward) * hitinfo.distance, Color.green);
        }
        else
        {
            myInteractButton_Script.IsInteractButtonTrue = false;

            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitinfo.distance, Color.blue);
        }
    }
}
