using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public static Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(0.05f, 0.05f, 0.05f);
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (this.transform.localScale.x >= 0)
        {
            transform.localScale -= scaleChange * Time.deltaTime * 10;

        }
        else Destroy(gameObject);
    }
}
