using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForR2L2 : MonoBehaviour
{
    
    public GameObject R2L2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int nrEn = 0;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject i in enemies)
        {
            nrEn++;
        }
        if(nrEn == 0)
        {
            Instantiate(R2L2);
           

            Destroy(gameObject);

        }
    }

    void Instantiate(GameObject i)
    {

        Vector3 help = new Vector3(43, 4.2f, -342);
        Instantiate(i, help, transform.rotation);
    }
}
