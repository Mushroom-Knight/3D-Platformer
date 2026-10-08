using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    int wholeNumber = 3;
    float decimalNumber = 3.45f;
    string text = "femboys";
    bool condition = false;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.linearVelocity = new Vector3(GetComponent<Rigidbody>().linearVelocity.x, 5, GetComponent<Rigidbody>().linearVelocity.z);
        }
        
        if (Input.GetKeyDown("space"))
        {
            rb.linearVelocity = new Vector3(GetComponent<Rigidbody>().linearVelocity.x, 5, GetComponent<Rigidbody>().linearVelocity.z);
        }

        if (Input.GetKey("up"))
        {
            rb.linearVelocity = new Vector3(0, 0, 5f);
        }

        if (Input.GetKey("right"))
        {
            rb.linearVelocity = new Vector3(5f, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            rb.linearVelocity = new Vector3(-5f, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            rb.linearVelocity = new Vector3(0, 0, -5f);
        }
    }
}
