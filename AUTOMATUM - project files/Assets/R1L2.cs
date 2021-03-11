using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R1L2 : MonoBehaviour
{
    
    public GameObject wallSound;
    
    public TriggerOne trigger;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject exit = GameObject.Find("l1trigger");
        trigger = exit.GetComponent<TriggerOne>();


    }

    // Update is called once per frame
    void Update()
    {
        CheckEn();
    }
    bool instantiated = false;
    void CheckEn()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        
        int enNr = 0;
        foreach (GameObject i in enemies)
            enNr++;
        print("R2L2 has " + enNr);
        if (enNr == 0) 
        {
            if (instantiated == false)
            {
                Instantiate(wallSound, transform.position, transform.rotation);
                instantiated = true;
            }
            trigger.LowerExit();
        }

    }
}
