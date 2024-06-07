using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [Header("Settings")]
    public float mouseSensitivity = 100f;
    public Transform cameraTransform;
    public Transform playerTransform;
    public bool invertYAxis = false;

    private float xRotation = 0f;
    private bool isCursorLocked = true;

    void Start()
    {
        LockCursor(true);
    }

    void Update()
    {
        HandleMouseLook();
        HandleCursorLock();
    }

    void HandleMouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        if (invertYAxis)
        {
            xRotation += mouseY;
        }
        else
        {
            xRotation -= mouseY;
        }

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerTransform.Rotate(Vector3.up * mouseX);
    }

    void HandleCursorLock()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isCursorLocked = !isCursorLocked;
            LockCursor(isCursorLocked);
        }
    }

    void LockCursor(bool shouldLock)
    {
        if (shouldLock)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
