using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{

    int coins = 0;

    [SerializeField] TMP_Text coinsText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            coins++;
            Debug.Log("yummers" + coins);
            coinsText.text = "points: " + coins;
        }
    }
}

