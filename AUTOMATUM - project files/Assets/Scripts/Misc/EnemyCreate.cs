using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{

    static int maxEnemyCount = 30;
    public static int enemyCount = 0;
    public GameObject enemy_Model;


    static Vector2[] enLocations = new Vector2[maxEnemyCount];

    // Start is called before the first frame update
    void Start()
    {
        
            InvokeRepeating("EnemyAppears", 1.0f, 0.1f);

    }

    void EnemyAppears()
    {

        if (enemyCount < maxEnemyCount)
        {
            CheckPlaced(enLocations);            
        }
        else CancelInvoke();
    }

    private void CheckPlaced(Vector2[] enLocations)
    {
        bool placed = false;
        while (placed == false) 
        {
            Vector2 tempPlace = TempPlace();
            int loc = 0;
            bool helpPlaced = false;

            for (int i = 0; i < maxEnemyCount; i++)
            {
                loc = i;
                if (enLocations[i] == tempPlace)
                {
                    
                    helpPlaced = true;
                    break;
                }
            }
            if(helpPlaced == true)
            {
                placed = false;
                
            }
            else
            {

                Instantiate(enemy_Model, tempPlace, transform.rotation);

                for (int i = 0; i < maxEnemyCount; i++)
                {
                    for (int j = 0; j < maxEnemyCount; j++)
                        if (enLocations[i] == enLocations[j] && i != j)
                            print("collided");
                }
                

               // print(tempPlace);
                enemyCount++;
                placed = true;
                enLocations[loc] = tempPlace;
                break;
            }
           
        }
      
    }


   

    public Vector2 TempPlace()
    {
        float y = Random.Range(-5, 5);
        float z = Random.Range(-5, 5);
        Vector2 tempPlace = new Vector2(y, z);
        

        return tempPlace;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
