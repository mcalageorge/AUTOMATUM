using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R1L1 : MonoBehaviour
{
    public static int nrEn = 8;
    public int enEnHelp = nrEn;
    public GameObject R1L2;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckEn();
    }

    

    void CheckEn()
    {
        
        GameObject[] nrEnChecked = GameObject.FindGameObjectsWithTag("Enemy");
       
        int added = 0;
        foreach (GameObject i in nrEnChecked)
            added++;
        print("there are " + added + " enemies");

        if (added == 0)
        {
            InstantiateR1L2();
            Destroy(gameObject);
        }
    }
    void InstantiateR1L2()
    {
        Vector3 help = new Vector3(-10.757452f, 3.96009f, -190.0015f);
       
        Instantiate(R1L2, help, transform.rotation);
    }
}
