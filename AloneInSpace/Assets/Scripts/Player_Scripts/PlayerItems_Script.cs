using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems_Script : MonoBehaviour
{
    public GameObject orientation;

    public bool hasFlashlight;
    public bool hasRepairTool;
    public bool solarGun;

    ItemsFollow_Player myItemsClass = new ItemsFollow_Player();
    

    void Start()
    {
        //verwijder
        hasFlashlight = true;
        //*
    }

    void Update()
    {
        myItemsClass.FollowOrientation();
    }
}

public class ItemsFollow_Player
{
    public string wichItems;

    public void FollowOrientation()
    {
        
    }

    //FlashLight.transform.rotation = orientation.transform.rotation;
}
