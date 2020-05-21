using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Transform obstacle;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;

    }
}
