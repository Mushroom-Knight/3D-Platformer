using UnityEngine;

public class StickyPlatforms : MonoBehaviour
{

    Vector3 lastPosition;
    Rigidbody playerRb;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "your ugly mug")
        {
            playerRb = collision.rigidbody;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "your ugly mug")
        {
            playerRb = null;
        }
    }
    void Start()
    {
        lastPosition = transform.position;
    }

    void FixedUpdate()
    {
        // How far the platform moved since last time
        Vector3 platformMove = transform.position - lastPosition;

        // Move the player by the same amount
        if (playerRb != null)
        {
            playerRb.MovePosition(playerRb.position + platformMove);
        }

        lastPosition = transform.position;
    }


}
