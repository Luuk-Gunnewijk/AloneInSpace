using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIft_Script : MonoBehaviour
{
    [Header("Lift")]
    public GameObject lift;

    [Header("Floors")]
    public GameObject floor1;
    public GameObject floor2;
    public GameObject floor3;

    [SerializeField] float liftSpeed = 10f;

    Vector3 floor1Position;
    Vector3 floor2Position;
    Vector3 floor3Position;

    private void Start()
    {
        floor1Position = floor1.transform.position;
        floor2Position = floor2.transform.position;
        floor3Position = floor3.transform.position;

    }

    private void Update()
    {
        MoveToFirstFloor();
        MoveToSecondFloor();
        MoveToThirdFloor();

        
    }

    void MoveToFirstFloor()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            lift.transform.position = floor1Position;
        }
    }

    void MoveToSecondFloor()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            lift.transform.position += floor2Position;
        }
    }

    void MoveToThirdFloor()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            lift.transform.position = floor3Position;
        }
    }
}
