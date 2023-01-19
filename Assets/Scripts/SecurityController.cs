using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityController : MonoBehaviour
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
        if (pathManagerCheckResult.Item3 && StandIndexNow <= pathManager.pathPositions.Count - 1)
        {
            StandIndexNow = pathManagerCheckResult.Item2;
            Vector3 vectorPosition = new Vector3(pathManagerCheckResult.Item1.position.x, gameObject.transform.position.y, pathManagerCheckResult.Item1.position.z);
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, vectorPosition, _speed);
            gameObject.GetComponent<Animator>().SetBool("Walk", true);
        }
    }
}
