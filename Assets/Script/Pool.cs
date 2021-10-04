using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pool : MonoBehaviour
{
    public List<Kim_Behaviour> kims = new List<Kim_Behaviour>();
    public GameObject kimPrefab;
    
    
    public Kim_Behaviour Create(Vector3 position, Quaternion rotation)
    {
        Kim_Behaviour kim = null;
        if (kims.Count >0)
        {
            kim = kims[0];
            kims.RemoveAt(0);
            kim.transform.rotation = rotation;
            kim.transform.position = position;
            kim.gameObject.SetActive(true);
        }
        else
        {
            GameObject kimGo = Instantiate(kimPrefab, position, rotation); //creation
            kim = kimGo.GetComponent<Kim_Behaviour>(); //chercher composant
        }
        return kim;

    }
    public void Kill(Kim_Behaviour kim)
    {
        kim.Restore();
        kim.gameObject.SetActive(false);
        kims.Add(kim);
    }


}
