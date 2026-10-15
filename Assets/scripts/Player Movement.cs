using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    [Header(" Player info")]
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] int wholeNumber = 3;
    [SerializeField] float decimalNumber = 3.45f;
    [Header(" Player text")]
    [SerializeField] string text = "femboys";
    [SerializeField] bool condition = false;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    [SerializeField] AudioSource jumpSound;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        rb.linearVelocity = new Vector3(horizontalInput * movementSpeed, rb.linearVelocity.y, verticalInput * movementSpeed);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
            jumpSound.Play();
        }
    }

    void Jump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, rb.linearVelocity.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject .CompareTag ("weak point"))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
        }
    }

    bool IsGrounded ()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
    
}

// thomas you are on video 7 at 17:00