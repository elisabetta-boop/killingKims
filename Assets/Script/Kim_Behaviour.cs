using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class Kim_Behaviour : MonoBehaviour
{
    //private NavMeshAgent agent;
    //private Destination destinationDie;
    public Vector3 destination;
    
    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }
    
    // public void SetDestination(Destination destination)
    // {
    //     agent.SetDestination(destination.transform.position);
    //     // cubeDestination = cube;
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown() {
        Destroy(gameObject);
    }
    

}
