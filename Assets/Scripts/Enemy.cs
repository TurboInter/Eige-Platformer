using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public bool invincible = false;
    public float bumpSpeed = 4f;
    
    private Rigidbody enemyRigidBody = null;

    private void Awake()
    {
        enemyRigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        enemyRigidBody.velocity = new Vector3(speed, enemyRigidBody.velocity.y, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("End"))
        {
            speed *= -1;
        }
    }

    public void onDeath()
    {
        GetComponent<Collider>().enabled = false;
    }
}
