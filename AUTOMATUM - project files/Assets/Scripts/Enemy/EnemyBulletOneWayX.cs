using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyBulletOneWayX : MonoBehaviour
{
    public float destroyTime = 3f;
    public float enemyBulletSpeed = 30f;
    GameObject player;
    Health hp;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("GameController");
        Destroy(gameObject, destroyTime);
        hp = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, enemyBulletSpeed * Time.deltaTime);

        if (hp.HP == 2)
        {
            Destroy(GameObject.FindGameObjectWithTag("three"));
            print("ola");
   

        }
        else if (hp.HP == 1)
        {
            Destroy(GameObject.FindGameObjectWithTag("two"));
            print("olax2");
  

        }
        else if (hp.HP == 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("one"));
            print("Dead");
            SceneManager.LoadScene(4);

        }
    }

    
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Sphere")
            hp.HP--;
        print("HP IS TRIGGER: " + hp.HP + "ball");
       
    }

    
}
