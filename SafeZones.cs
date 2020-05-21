using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZones : MonoBehaviour
{
    public GameObject player,
                     enemy;

    void OnTriggerStay(Collider collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
        Physics.IgnoreCollision(player.GetComponent<Collider>(), enemy.GetComponent<Collider>());
        }
    }
    
    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
        Physics.IgnoreCollision(player.GetComponent<Collider>(), enemy.GetComponent<Collider>(), false);
        }
    }
}
