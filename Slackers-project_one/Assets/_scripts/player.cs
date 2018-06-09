﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class player : MonoBehaviour
{
    public Transform playerBody;
    public float mouseSensitivity;

    float xAxisClamp = 0.0f;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
	
	// Update is called once per frame
	void Update () {
        RotateCamera();
        
	}

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float rotAmountX = mouseX * mouseSensitivity;
        float rotAmountY = mouseY * mouseSensitivity;

        xAxisClamp -= rotAmountY;

        Vector3 targetRotCam = transform.rotation.eulerAngles;

        Vector3 targetRotBody = playerBody.rotation.eulerAngles;

        targetRotCam.x -= rotAmountY;
        targetRotCam.z = 0;
        targetRotCam.y += rotAmountX;

        if(xAxisClamp > 90)
        {
            xAxisClamp = 90;
          targetRotCam.x = 90;
        }
        else if (xAxisClamp < -90)
        { xAxisClamp = -90;
            targetRotCam.x = 270;
        }

        transform.rotation = Quaternion.Euler(targetRotCam);
        playerBody.rotation = Quaternion.Euler(targetRotBody);

    }

}
