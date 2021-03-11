using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereShoot : MonoBehaviour
{
    public GameObject softBullet;
    public GameObject hardBullet;
    public const float actualTimer = 0.05f;
    public float timer = actualTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 3f)
        {
            int x = Random.Range(0, 2);
            if (x == 0)
            {
                
                transform.Rotate(0, Random.Range(0, 366f), 0);
                InstantiateSoft();
            }
            else 
            {
                transform.Rotate(0, Random.Range(0, 366f), 0);
                InstantiateHrd();
            }

            timer = actualTimer;
        }
        else timer += 50f * Time.deltaTime;

        print("IAM " + timer);

    }

    void InstantiateSoft()
    {
        Instantiate(softBullet,transform.position, transform.rotation);
    }
    void InstantiateHrd()
    {
        Instantiate(hardBullet, transform.position, transform.rotation);
    }
}
