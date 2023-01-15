using System;
using System.Collections.Generic;
using UnityEngine;

public class BuyerController : MonoBehaviour
{
    private float _speed = .05f;

    public int StandIndexNow = 0;

    public PathManager pathManager;

    void Start()
    {
        pathManager = FindObjectOfType<PathManager>().GetComponent<PathManager>();
    }

    void Update()
    {
        (Transform, int, bool) pathManagerCheckResult = pathManager.CheckNextPosition(StandIndexNow);
        if (pathManagerCheckResult.Item3 && StandIndexNow <= 9)
        {
            StandIndexNow = pathManagerCheckResult.Item2;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, pathManagerCheckResult.Item1.position, _speed);
        }
    }
}
