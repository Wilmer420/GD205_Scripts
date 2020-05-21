using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    float dist;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.red);
        RaycastHit hit;  

        if (Physics.Raycast(ray, out hit, 5f) && Input.GetMouseButtonDown(0))
        {
            if(hit.transform.CompareTag("Enemy"))
            {
                Destroy(hit.collider.gameObject);
            }
        }
    
    }
}
