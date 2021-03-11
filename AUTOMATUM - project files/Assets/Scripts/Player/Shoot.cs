using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Shoot : MonoBehaviour
{
    public const float actualTimer = 0.3f;
    float timer = actualTimer;
    public GameObject bullet;
    bool shot = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        print(timer);
        if (Input.GetMouseButton(0) && shot == false)
        {
            print("yey");
            InstantiateBullet();




            shot = true;
            
        }
        if(shot == true)
        {
            timer = timer - 2 * Time.deltaTime;
        }
        if (timer <= 0) { shot = false;  timer = actualTimer; }
    }
    void InstantiateBullet()
    {  
        Instantiate(bullet, transform.position, transform.rotation);
       
    }

   
}
