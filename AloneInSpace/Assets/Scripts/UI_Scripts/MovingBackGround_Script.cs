using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBackGround_Script : MonoBehaviour
{
    [SerializeField] RawImage myImage;
    [SerializeField] float myX, myY;

    private void Update()
    {
        myImage.uvRect = new Rect(myImage.uvRect.position + new Vector2(myX, myY) * Time.deltaTime, myImage.uvRect.size);
    }
}
