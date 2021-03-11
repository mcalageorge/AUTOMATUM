using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed = 3f;
    public GameObject bullet;
    Transform tr;
   


    public float timeBullets = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateBullet", 1f, timeBullets);
        tr = GameObject.FindWithTag("Player").GetComponent<Transform>();
        print(tr.transform.position);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 temp = tr.transform.position;
        temp.y = transform.position.y;
        float dist = Vector3.Distance(transform.position, tr.transform.position);
        if (dist > 10f)
        transform.position = Vector3.MoveTowards(transform.position, temp, speed * Time.deltaTime);

        
        transform.LookAt(temp);
        
    }
    
    void InstantiateBullet()
    {
        
       
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
