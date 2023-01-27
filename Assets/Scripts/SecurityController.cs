using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SecurityController : MonoBehaviour
{
    private NavMeshAgent agent;
    private int i;
    public List<Transform> targets;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        TargetUpdate();
    }

    private void TargetUpdate()
    {
        i = Random.Range(0, targets.Count);
    }

    void Update()
    {
        if (agent.transform.position == agent.pathEndPosition)
        {
            TargetUpdate();
        }
        agent.SetDestination(targets[i].position);
    }
}
