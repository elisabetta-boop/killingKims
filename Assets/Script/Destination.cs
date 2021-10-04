using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Destination : MonoBehaviour
{
    public Pool pool;
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        Kim_Behaviour kim = other.GetComponent<Kim_Behaviour>();
        if(kim != null) {
           pool.Kill(kim);
        }
    }
    // public void OnTriggerEnter(Collider collision) {
    //     if (collision.CompareTag("Bad"))
    //     {
    //         Kim_Behaviour kim = other.GetComponent<Kim_Behaviour>();
    //         if (kim!= null) {
    //             pool.Kill(kim);
    //         }
    //         // Destroy(collision.gameObject);
    //         // print("Destroyyyyyy");
    //         // Debug.Log("miao");
            

    //     }
    // }
        
}

