using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOne : MonoBehaviour
{
    public GameObject r1l1;
    public GameObject wallEntrance;
    public GameObject wallExit;

    public GameObject music; 

    Transform entrance;
    Transform exit;

    // Start is called before the first frame update
    
        void Start()
    {
        entrance = wallEntrance.GetComponent<Transform>();
        exit = wallExit.GetComponent<Transform>();
    }

   void OnTriggerEnter(Collider hit)
   {
        print("walltrigger");
        if (entrance.position.y < -1.5 && hit.gameObject.tag == "Player")
        {
            Instantiate(music);
            exit.Translate(0, 14f, 0);
            entrance.Translate(0, 14f, 0);
            Vector3 help = new Vector3(16, 0, -185);
            Instantiate(r1l1, help, transform.rotation);
            
        }
   }
   public void LowerExit()
    {
        exit.Translate(0, -6.5f * Time.deltaTime, 0);
        print("lowered");
        //if (exit.transform.position.y < -10.3f)
            //Destroy(wallExit);
        //Destroy(gameObject, 1.5f);
    }
}
