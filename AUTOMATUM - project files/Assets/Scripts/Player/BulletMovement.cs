using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    float bulletSpeed = 90f;
    public GameObject body;
    public GameObject explosion;
    public GameObject bulletSound;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 1f);
        Instantiate(bulletSound);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(0, 0, bulletSpeed * Time.deltaTime);
        
    }
    void OnCollisionEnter(Collision q)
    {
        print("oi");

        if (q.gameObject.tag == "Enemy")
        {
            Destroy(q.gameObject);
            body.SetActive(false);
            print("collider");
            Instantiate(explosion);

            //  Destroy(gameObject);
            // gameObject.SetActive(false);
        }



    }
    void OnTriggerEnter(Collider q)
    {
        print("rrrrrrrrrrrrrrrrrrrrrrrrrrr");
        if (q.gameObject.tag == "EnemyBullet")
        {

            Destroy(q.gameObject);
            //body.SetActive(false);
            Destroy(gameObject);



            //    Destroy(gameObject);
            //    Destroy(q.gameObject);
        }
        else if(q.gameObject.tag == "Dummy")
        {
            body.SetActive(false);
        }

    }

    void Instantiate(GameObject explosion)
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }

}
