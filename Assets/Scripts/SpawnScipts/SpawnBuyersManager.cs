using System.Collections;
using UnityEngine;

public class SpawnBuyersManager : MonoBehaviour
{
    public GameObject spawnPoint;

    public GameObject[] Buyers;

    public PathManager pathManager;

    public float startTimeSpawn = 19;
    private float timeSpawn;

    void Start()
    {

        foreach (var buyer in Buyers)
        {
            buyer.GetComponent<BuyerController>().pathManager = pathManager;
        } 
        timeSpawn = startTimeSpawn;
    }

    void Update()
    {
        if (timeSpawn <= 0)
        {
            if (pathManager.GetFirstPositionOpen())
            {
                timeSpawn = startTimeSpawn;
                Instantiate(Buyers[Random.Range(0, Buyers.Length)], spawnPoint.transform.position, Quaternion.identity);
            }
        }
        else
        {
            timeSpawn -= Time.deltaTime;
        }
    }
}
