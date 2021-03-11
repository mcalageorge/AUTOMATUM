using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lowering : MonoBehaviour
{
    GameObject t;
    // Start is called before the first frame update
    void Start()
    {
        t = GameObject.Find("ananas");
        if (t != null) print("ananas found");
    }

    // Update is called once per frame
    void Update()
    {
        t.transform.Translate(0, -6.5f * Time.deltaTime, 0);
        if(t.transform.position.y <= -10f)
        {
            Destroy(t.gameObject);
            Destroy(gameObject);
        }
    }
}
