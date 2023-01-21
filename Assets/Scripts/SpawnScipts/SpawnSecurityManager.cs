using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSecurityManager : MonoBehaviour
{
    public GameObject Security;

    public PathManager pathManager;

    public GameObject spawnPoint;

    public float startTimeSpawn = 19;
    private float timeSpawn;

    void Start()
    {
        Security.GetComponent<SecurityController>().pathManager = pathManager;
        timeSpawn = startTimeSpawn;
    }

    void Update()
    {
        if (timeSpawn <= 0)
        {
            if (pathManager.GetFirstPositionOpen())
            {
                timeSpawn = startTimeSpawn;
                Instantiate(Security, spawnPoint.transform.position, Quaternion.identity);
            }
        }
        else
        {
            timeSpawn -= Time.deltaTime;
        }
    }

}
