using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFaceCamera : MonoBehaviour
{

    void Update()
    {
        //get direction (pos of the canvas - pos of the camera)
        Vector3 direction = transform.position - Camera.main.transform.position;

        //set forward of the canvas
        transform.forward = direction;
    }
}
