using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 6f);
    }

    bool red = false;
    bool dark = true;
    float timer = 2f;

    // Update is called once per frame
    void Update()
    {
        if (dark == true)
        {
            timer -= timer * 50 * Time.deltaTime;
            if (timer <= 0)
            {
                print("changed");
                GetComponent<Text>().color = Color.red;
                red = true;
                dark = false;
                timer = 2f;
            }
        }
        else
        {
            timer -= timer * 50 * Time.deltaTime;
            if (timer <= 0)
            {
                print("changed");
                GetComponent<Text>().color = Color.black;
                red = false;
                dark = true;
                timer = 2f;
            }
        }
        }

    
}
