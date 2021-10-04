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
    private Pool pool;
    
    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();
        pool = FindObjectOfType<Pool>();
    }
    
    // public void SetDestination(Destination destination)
    // {
    //     agent.SetDestination(destination.transform.position);
    //     // cubeDestination = cube;
    // }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }
    
    void OnMouseDown() {
        //Destroy(gameObject);
        pool.Kill(this);
    }
    

}
