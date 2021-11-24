using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navagent : MonoBehaviour
{
    [SerializeField]
    Transform destination;

    // Start is called before the first frame update
    void Start()
    {
        if (destination != null) 
            GetComponent<NavMeshAgent>().SetDestination(destination.position);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
