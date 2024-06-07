using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public float sprintSpeedMultiplier = 1.5f;
    public float rotationSpeed = 100.0f;
    public float jumpForce = 8.0f;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Rotaèní pohyb hráèe
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        // Skok
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        float translationZ = Input.GetAxis("Vertical") * speed;

        float translationX = Input.GetAxis("Horizontal") * speed;

        if (Input.GetKey(KeyCode.LeftShift) && translationZ > 0)
        {
            translationZ *= sprintSpeedMultiplier;
        }

        Vector3 movement = (transform.forward * translationZ + transform.right * translationX) * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
