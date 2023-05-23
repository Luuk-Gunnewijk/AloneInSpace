using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast_Script : MonoBehaviour
{
    public bool isRayCastTrue = false;

    [SerializeField] LayerMask myLayerMask;
    RaycastHit hitinfo;
    void Update()
    {
        Raycast();
    }

    void Raycast()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitinfo, 5f))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection (Vector3.forward) * hitinfo.distance, Color.green);
            isRayCastTrue = true;
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitinfo.distance, Color.blue);
            isRayCastTrue = false;
        }
    }
}
