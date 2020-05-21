using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public float boomAmt;
    

    void Update()
    {
        
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit = new RaycastHit();

        Debug.DrawRay(laser.origin, laser.direction, Color.green);

        if (Physics.Raycast(laser, out hit, 10000f) && Input.GetMouseButton(0)) 
        {
            if (hit.rigidbody)
            {
                hit.rigidbody.AddForce(0,180,200);
            }
           
            Debug.Log("you hit something ... " + hit.transform.gameObject.name);
        }

    }
}
