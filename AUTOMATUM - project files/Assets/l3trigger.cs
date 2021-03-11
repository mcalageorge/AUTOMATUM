using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l3trigger : MonoBehaviour
{
    public GameObject walle;
    public GameObject L3MANAGER;

    void OnTriggerEnter(Collider hit)
    {
        walle.SetActive(true);
        
        Instantiate(L3MANAGER, transform.position, transform.rotation);

        GameObject[] inst = GameObject.FindGameObjectsWithTag("L3MANAGER");

        int nr = 0;

        foreach(GameObject i in inst)
        {
            nr++;
        }
        if(nr > 1)
        {
            for(int i = 1; i < inst.Length; i++)
            {
                Destroy(inst[i].gameObject);
            }
        }
        Destroy(gameObject);
    }
}
