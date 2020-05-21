using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyalert : MonoBehaviour
{
	NavMeshAgent enemy;
    // Start is called before the first frame update
    void Start()
    {
		enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider triggerReport)
	{
        if (triggerReport.CompareTag("Player"))
		{
			enemy.SetDestination(triggerReport.transform.position);
		}
	}
}
