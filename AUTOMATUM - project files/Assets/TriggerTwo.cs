using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTwo : MonoBehaviour
{
    public GameObject wallExit;
    public GameObject wallEntrance;
    bool entered = false;

   public GameObject firstWave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider hit)
    {
        if (entered == false)
        {
            wallEntrance.SetActive(true);
            wallExit.SetActive(true);
            entered = true;
            Instantiate();
            Destroy(gameObject);
        }


    }
    void Instantiate()
    {
        Vector3 help = new Vector3(46, 5, -342);
        Instantiate(firstWave, help, transform.rotation);
    }
}
