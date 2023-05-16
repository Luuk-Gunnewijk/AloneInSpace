using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight_Script : MonoBehaviour
{
    Light FlashLight;

    public GameObject orientation;

    AudioSource flashLightSound;
    PlayerItems_Script myPlayerItemScript;

    public AudioClip flaslightOn;
    public AudioClip flaslightOff;

    private void Awake()
    {
        myPlayerItemScript = FindObjectOfType<PlayerItems_Script>();
    }

    private void Start()
    {
        FlashLight = GetComponent<Light>();
        flashLightSound = GetComponent<AudioSource>();

        FlashLight.enabled = false;
    }

    private void Update()
    {
        SwitchLight();
        FollowOrientation();
    }

    void SwitchLight()
    {
        if (myPlayerItemScript.hasFlashlight == false)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.F) && FlashLight.enabled == true) 
        {
            flashLightSound.PlayOneShot(flaslightOff);
            FlashLight.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.F) && FlashLight.enabled == false)
        {
            flashLightSound.PlayOneShot(flaslightOn);
            FlashLight.enabled = true;
        }
    }

    void FollowOrientation()
    {
        FlashLight.transform.rotation = orientation.transform.rotation;
    }
}
