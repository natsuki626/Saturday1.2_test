using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 1000f;

    private float xRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        xRotation = transform.localEulerAngles.x;

        if (xRotation > 180f)
        {
            xRotation -= 360f;
        }
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        transform.parent.Rotate(Vector3.up * mouseX);
    }
}