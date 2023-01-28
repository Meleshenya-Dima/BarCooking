using System;
using System.Collections.Generic;
using UnityEngine;

public class BuyerController : MonoBehaviour
{
    private float _speed = 2f;

    public int StandIndexNow = 0;

    public PathManager pathManager;

    private Vector3 _vectorPosition;
    void Update()
    {
        (Transform, int, bool) pathManagerCheckResult = pathManager.CheckNextPosition(StandIndexNow);
        if (pathManagerCheckResult.Item3 && StandIndexNow <= pathManager.pathPositions.Count - 1)
        {
            StandIndexNow = pathManagerCheckResult.Item2;
            Vector3 vectorPosition = new Vector3(pathManagerCheckResult.Item1.position.x, gameObject.transform.position.y, pathManagerCheckResult.Item1.position.z);
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, vectorPosition, _speed * Time.deltaTime);
            _vectorPosition = vectorPosition;
            Vector3 vector3LookPosition = new Vector3(pathManagerCheckResult.Item1.position.x, gameObject.transform.position.y, pathManagerCheckResult.Item1.position.z);
            transform.LookAt(vector3LookPosition);
        }
        if (gameObject.transform.position != _vectorPosition)
        {
            gameObject.GetComponent<Animator>().SetBool("Walk", true);
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("Walk", false);
        }
    }
}
