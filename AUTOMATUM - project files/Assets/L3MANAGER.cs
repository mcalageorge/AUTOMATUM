using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class L3MANAGER : MonoBehaviour
{
    public GameObject enemySimple;
    public GameObject enemyCyl;
    public GameObject enemyBoss;

    
    public Canvas death;

    public float death_timer = 10f;

    // Start is called before the first frame update
    void Start()
    {
      
    }
    int wave = 0;
    int A = 15;
    int a = 0;

    int B = 8;
    int b = 0;

    int C = 5;
    int c = 0;

    int r = 0;
    int g = 0;

    bool displayed = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(death);
            death.gameObject.SetActive(true);
        }

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        int y = 0;
        foreach (GameObject i in enemies)
            y++;
        if (y == 0 && wave < 5)
        {
            a = 0;
            wave++;
            print("wave is " + wave);
            while (a <= A)
            {
                float x = Random.Range(-58, -165);
                float z = Random.Range(-313, -420);
                Vector3 pos = new Vector3(x, 5, z);

                print("x = " + x + "&& " + "z = " + z);
                Instantiate(enemySimple, pos, transform.rotation);
                a++;
            }
        }
        else if(y == 0 && wave >= 5 && wave < 10)
        {
            a = 0;
            wave++;
            print("wave is " + wave);
            while (b <= B)
            {
                float x = Random.Range(-58, -165);
                float z = Random.Range(-313, -420);


                Vector3 pos = new Vector3(x, 5, z);

                print("x = " + x + "&& " + "z = " + z);
                Instantiate(enemySimple, pos, transform.rotation);

                x = Random.Range(-58, -165);
                z = Random.Range(-313, -420);

                pos = new Vector3(x, 5, z);

                Quaternion rot = new Quaternion(0, x, 0, x);
                
                    
                Instantiate(enemyCyl, pos, rot);

                b++;
            }
        }

        else if(y == 0 && wave >= 10 && wave < 13)
        {
            c = 0;
            wave++;
            print("wave is " + wave);

            
            
            if (displayed == false)
            {
                
                Instantiate(death);
                
                displayed = true;
                
            }
            

            while (c <= C)
            {
                
                float x = Random.Range(-58, -165);
                float z = Random.Range(-313, -420);


                Vector3 pos = new Vector3(x, 5, z);

                print("x = " + x + "&& " + "z = " + z);
                Instantiate(enemyBoss, pos, transform.rotation);

                c++;
            }
            
        }
        else if(y == 0 && wave == 13)
        {

            SceneManager.LoadScene(5);

            
        }

        
        
    }
}
