//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ProjectileShooter : MonoBehaviour
//{
//	GameObject prefab;
//    void Start()
//    {
//		prefab = Resources.Load("projectile") as GameObject;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0))
//		{
//			GameObject projectiles = Instantiate(prefab) as GameObject;
//			projectiles.transform.position = transform.position + Camera.main.transform.forward * 2;
//			Rigidbody rb = projectiles.GetComponent<Rigidbody>();
//            rb.velocity = Camera.main.transform.forward * 40;
//		}
//    }
//}
