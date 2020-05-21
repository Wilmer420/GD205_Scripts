using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playernav : MonoBehaviour
{

    NavMeshAgent player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(laser, out hit) && Input.GetMouseButtonDown(0))
        {
            player.SetDestination(hit.point);
        }
    }
}
