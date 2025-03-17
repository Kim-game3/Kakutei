using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshTest : MonoBehaviour
{
    [SerializeField] NavMeshAgent _navMeshAgent;
    [SerializeField] Transform _goal;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent.SetDestination(_goal.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
