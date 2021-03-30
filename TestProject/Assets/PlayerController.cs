using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    public bool MoveTo(Vector3 pos)
    {
        return navMeshAgent.SetDestination(pos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
