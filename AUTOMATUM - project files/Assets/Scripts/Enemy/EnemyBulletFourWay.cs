using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletFourWay : MonoBehaviour
{
    public GameObject bullet0;
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;
    public float timeBullets = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Instantiate", 1f, timeBullets);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instantiate()
    {

        Instantiate(bullet0, transform.position, transform.rotation);
        Instantiate(bullet1, transform.position, transform.rotation);
        Instantiate(bullet2, transform.position, transform.rotation);
        Instantiate(bullet3, transform.position, transform.rotation);
    }
}
