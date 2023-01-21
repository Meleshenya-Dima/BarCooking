using System.Collections;
using UnityEngine;

public class SpawnBuyersManager : MonoBehaviour
{
    public GameObject spawnPoint;

    public GameObject Buyer;

    public PathManager pathManager;

    public float startTimeSpawn = 19;
    private float timeSpawn;

    void Start()
    {
        Buyer.GetComponent<BuyerController>().pathManager = pathManager;
        timeSpawn = startTimeSpawn;
    }

    void Update()
    {
        if (timeSpawn <= 0)
        {
            if (pathManager.GetFirstPositionOpen())
            {
                timeSpawn = startTimeSpawn;
                Instantiate(Buyer, spawnPoint.transform.position, Quaternion.identity);
            }
        }
        else
        {
            timeSpawn -= Time.deltaTime;
        }
    }
}
