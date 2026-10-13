using UnityEngine;

public class StickyPlatforms : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "your ugly mug")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "your ugly mug")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }


}
