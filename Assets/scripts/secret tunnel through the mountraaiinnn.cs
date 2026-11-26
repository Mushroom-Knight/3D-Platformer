using Unity.VisualScripting;
using UnityEngine;

public class secrettunnelthroughthemountraaiinnn : MonoBehaviour
{
    public ItemCollector itemcol;

    private Vector3 previouspos;

    [SerializeField] GameObject[] waypoints;
    int currentWayPointIndex = 0;

    [SerializeField] float speed = 1f;

    private void Start()
    {
        previouspos = transform.position;
    }


    private void Update()
    {
        if (itemcol.coins >= 4)
        {
            if (Vector3.Distance(transform.position, waypoints[currentWayPointIndex].transform.position) < .1f)
            {
                currentWayPointIndex++;
                if (currentWayPointIndex >= waypoints.Length)
                {
                    currentWayPointIndex = 0;
                }

            }


            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWayPointIndex].transform.position, speed * Time.deltaTime);
        }
    }
}
