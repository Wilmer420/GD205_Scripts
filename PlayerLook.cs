using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    // mouseSensitivty can be modified in Unity to adjust the speed of the mouse.
    // playerBody must be referenced in Unity to allow the camera rotation to rotate the player body.
    public float mouseSensitivity;

    public Transform playerBody;
    public float rotateSpeed = 100f;

    // Rotation on the x-axis (up and down) uses a private float to limit movement.
    float xRotation = 0f;

    // Variable to enable or disable the cursor
    public static bool hideCursor;


    // Start is called before the first frame update
    void Start()
    {
        // // This makes the cursor disappear once the game begins to avoid clicking outside the window by mistake.
        // // Press Esc key in the game window to bring the cursor back.
        hideCursor = true;
        //if (MainMenu.mouseSet < 300)
        //{
        //    mouseSensitivity = 300;
        //}
        //else
        //{
        //    mouseSensitivity = MainMenu.mouseSet;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(mouseSensitivity);

        // // Hide the cursor during gameplay or menus
        //if (hideCursor)
        //{
        //    Cursor.lockState = CursorLockMode.Locked;
        //}
        //else
        //{
        //    Cursor.lockState = CursorLockMode.None;
        //}

        // Private variables to gather the mouse's x and y axis.
        // This is multiplied by the mouseSensitivity to control the speed and 
        // by Time.deltaTime to rotate independent of current framerate.
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // xRotation is used to calculate the angle of rotation along the x-axis (up and down).
        // Mathf.Clamp() takes a value (xRotation) and limits its output between two values (-90 and 90).
        //xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, 0f, 0f);

        // For the y rotation (up and down) we use transform.localRotation which takes a Vector3 value.
        // Quaternion is responsible for rotation in Unity and Euler gives us outpun in angles.
        // xRotation is the only value that we want to change so we use 0f for y and z.
        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Vector3.up * mouseX allows the playerBody.Rotate() to rotate along the y-axis (left and right).
        playerBody.Rotate(Vector3.up * mouseX);

        // if (Input.GetKey(KeyCode.D))
        // {
        //     playerBody.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        // }

        // if (Input.GetKey(KeyCode.A))
        // {
        //     playerBody.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
        // }

    }
}

