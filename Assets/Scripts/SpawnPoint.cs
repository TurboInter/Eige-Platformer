using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "spawnpoint");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerBehaviour>().spawnpoint = transform;
        }
    }
}
