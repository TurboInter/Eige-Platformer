using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlatform : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 5f;

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up, rotationSpeed);
    }
    
}
