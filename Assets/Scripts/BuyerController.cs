using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BuyerController : MonoBehaviour
{
    private float _speed = 2f;

    public int StandIndexNow = 0;

    public PathManager pathManager;

    private Vector3 _vectorPosition;

    private Vector3 _dancePosition;
    private NavMeshAgent agent;

    public Vector3 DancePosition
    {
        get
        {
            return _dancePosition;
        }
        set
        {
            _dancePosition = value;
            _isDance = true;
        }
    }

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private bool _isDance = false;

    void Update()
    {
        if (!_isDance)
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
                UpdateAnimatorState(_vectorPosition);
            }
        }
        else
        {
            if (UpdateAnimatorState(DancePosition))
            {
                Debug.Log(DancePosition);
                agent.SetDestination(DancePosition);
                transform.LookAt(DancePosition);
            }
        }
    }

    private bool UpdateAnimatorState(Vector3 position)
    {
        if (gameObject.transform.position != position)
        {
            gameObject.GetComponent<Animator>().SetBool("Walk", true);
            return true;
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("Walk", false);
            return false;
        }
    }


    public void DanceZonePosition(Transform spawnZone)
    {
        float maxX = 76;
        float minX = 64;

        float maxZ = 77;
        float minZ = 61;

        Vector3 movePos = new Vector3(UnityEngine.Random.Range(minX, maxX), 1, UnityEngine.Random.Range(minZ, maxZ));
        DancePosition = movePos;
    }
}
