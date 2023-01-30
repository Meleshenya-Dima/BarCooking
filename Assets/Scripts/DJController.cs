using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DJController : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform target;

    public Transform LookTarget;

    private bool _inPos = true;

    void Start()
    {
        Vector3 vector3LookPosition = new Vector3(LookTarget.position.x, gameObject.transform.position.y, LookTarget.position.z);

        agent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        if (_inPos)
        {
            agent.SetDestination(target.position);
            if (agent.transform.position == agent.pathEndPosition)
            {
                gameObject.transform.LookAt(LookTarget);
                _inPos = false;
            }
        }
    }
}
