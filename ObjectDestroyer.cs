using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectDestroyer : MonoBehaviour
{
	public GameObject inventory, diamond;

	public Text gemsText;

    void Update()
    {
       
		gemsText.text = "Inventory: " + inventory.transform.childCount;

        // 1. Test for mouse click
        if (Input.GetMouseButtonUp(0))
        {

            // 2. get mouse position in world space
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100f));

            //3. get direction vector from camera position to mouse position in world space
            Vector3 direction = worldMousePosition - Camera.main.transform.position;

            RaycastHit hit;

            //4. cast a ray from the camera in the given direction
            if (Physics.Raycast(Camera.main.transform.position, direction, out hit, 100f))
            {

                Debug.DrawLine(Camera.main.transform.position, hit.point, Color.green, 0.5f);

                // 5. Destroy game object
                if (hit.collider.gameObject.tag == "Enemy")
                {
					//  Destroy(hit.collider.gameObject);
					hit.collider.gameObject.transform.parent = inventory.transform;
					hit.collider.gameObject.SetActive(false);
					//	hit.collider.gameObject.GetComponent<Renderer>().enabled = false;
					diamond.transform.localScale += new Vector3(1, 1, 1);

                }

            }
            else
            {
                Debug.DrawLine(Camera.main.transform.position, worldMousePosition, Color.red, 0.5f);
            }
            if (inventory.transform.childCount == 50)
			{
				SceneManager.LoadScene("GameClear");
			}
			//if (Input.GetKeyDown(KeyCode.Z))
			//{
			//	Debug.Log("inventory: " + inventory.transform.childCount);

			//	bool grow = true;

			//	diamond.transform.localScale += new Vector3(inventory.transform.childCount, inventory.transform.childCount, inventory.transform.childCount);

			//	if (grow)
			//	{
			//		foreach (Transform child in inventory.transform)
			//		{
			//			Destroy(child.gameObject);
			//		}
			//		grow = false;
			//	}
			//}

		}

    }
}


