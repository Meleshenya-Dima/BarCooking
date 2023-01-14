using System;
using System.Collections.Generic;
using UnityEngine;

public class BuyerController : MonoBehaviour
{
    private float _speed = .005f;

    private int _standIndexNow = 0;

    public PathManager pathManager;

    void Update()
    {
        (Transform, int, bool) pathManagerCheckResult = pathManager.CheckNextPosition(_standIndexNow);
        if (pathManagerCheckResult.Item3 && _standIndexNow <= 9)
        {
            _standIndexNow = pathManagerCheckResult.Item2;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, pathManagerCheckResult.Item1.position, _speed);
        }
    }
}
