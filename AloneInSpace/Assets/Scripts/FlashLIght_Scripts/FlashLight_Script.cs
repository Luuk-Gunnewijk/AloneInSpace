using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight_Script : MonoBehaviour
{
    Light FlashLight;

    public GameObject orientation;

    AudioSource flashLightOn_Sound;

    private void Start()
    {
        FlashLight = GetComponent<Light>();
        flashLightOn_Sound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        SwitchLight();
        FollowOrientation();
    }

    void SwitchLight()
    {
        if (Input.GetKeyDown(KeyCode.F) && FlashLight.enabled == true) 
        {
            
            FlashLight.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.F) && FlashLight.enabled == false)
        {
            flashLightOn_Sound.Play();
            FlashLight.enabled = true;
        }
    }

    void FollowOrientation()
    {
        FlashLight.transform.rotation = orientation.transform.rotation;
    }
}
