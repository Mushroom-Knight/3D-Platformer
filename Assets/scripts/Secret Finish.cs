using UnityEngine;
using UnityEngine.SceneManagement;

public class SecretFinish : MonoBehaviour
{
    public int secretpoints = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "your ugly mug")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            secretpoints++;
            Debug.Log("yummers" + secretpoints);

        }
    }
}
