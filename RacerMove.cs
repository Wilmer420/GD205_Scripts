using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacerMove : MonoBehaviour
{

    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnim.SetInteger("MoveState", 0);
        if (Input.GetKey(KeyCode.W))
        {
            myAnim.SetInteger("MoveState", 1);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnim.SetInteger("MoveState", -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myAnim.SetInteger("MoveState", 2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myAnim.SetInteger("MoveState", -2);
        }
        if (Input.GetKey(KeyCode.S))
        {
            myAnim.SetInteger("MoveState", 3);
        }
    }
}
