﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonTime : MonoBehaviour
{
    // Start is called before the first frame update
    // camera speed
    public float speed = 2f;
    private float xRot = 0.0f;
    private float yRot = 0.0f;
    private Camera cam;
    private Vector3 targetRotation;
    private Vector3 rotateValue;
    private Quaternion rotation;

    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * speed;
        float mouseY = Input.GetAxis("Mouse Y") * speed;

        yRot += mouseX;
        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90, 90);

        rotateValue = new Vector3(xRot, yRot, 0);
        targetRotation = cam.transform.position + rotateValue;
        rotation = Quaternion.Euler(xRot, yRot, 0);
        cam.transform.rotation = rotation;
    }
}
