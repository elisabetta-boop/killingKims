using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Pool pool;
    public float delay = 1f;
    public Vector3 kimDestination;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        while(true)
        {
            Kim_Behaviour kim = pool.Create(transform.position, transform.rotation);
            //GameObject kim = Instantiate(kimPrefab, transform.position, transform.rotation);
            kim.destination = kimDestination;
            yield return new WaitForSeconds(delay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
