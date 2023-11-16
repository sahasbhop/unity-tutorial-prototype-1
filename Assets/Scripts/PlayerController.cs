using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public string verticalAxisName;
    public string horizontalAxisName;
    public string cameraToggleKeyCode;
    public Camera thirdPersonCamera;
    public Camera firstPersonCamera;

    // Start is called before the first frame update
    void Start()
    {
        thirdPersonCamera.enabled = true;
        firstPersonCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Enum.TryParse(cameraToggleKeyCode, true, out KeyCode parsedKeyCode);
        if (Input.GetKeyDown(parsedKeyCode))
        {
            thirdPersonCamera.enabled = !thirdPersonCamera.enabled;
            firstPersonCamera.enabled = !firstPersonCamera.enabled;
        }

        var verticalInput = Input.GetAxis(verticalAxisName);
        var horizontalInput = Input.GetAxis(horizontalAxisName);
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * verticalInput));
        transform.Rotate(Vector3.up * (Time.deltaTime * turnSpeed * horizontalInput));
    }
}