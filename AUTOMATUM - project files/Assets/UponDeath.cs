using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UponDeath : MonoBehaviour
{
    public GameObject lowering;
    public GameObject sounding;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int nrEn = 0;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject i in enemies)
        {
            nrEn++;
        }
        if (nrEn == 0)
        {
            Instantiate(lowering, transform.position, transform.rotation);
            Instantiate(sounding, transform.position, transform.rotation);

            Destroy(gameObject);

        }
    }
}
