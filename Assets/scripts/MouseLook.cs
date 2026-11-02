using UnityEngine;

public class MouseLook : MonoBehaviour
{

    [SerializeField] float mouseSensitivity = 2f;
    [SerializeField] Transform playerCamera;

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Read the mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Turn the whole player left and right
        transform.Rotate(Vector3.up * mouseX);

        // Tilt, but never past straight up or down
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }


    void LateUpdate()
    {
        // Tilt the camera up and down
        playerCamera.localRotation =
            Quaternion.Euler(xRotation, 0f, 0f);
    }

}
