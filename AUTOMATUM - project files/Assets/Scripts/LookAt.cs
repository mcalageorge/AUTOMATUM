using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    bool one, two, three, four;
    float speed = 50;
    float height = 300f;

    Vector3 unos = new Vector3(-40,150,44);
    Vector3 dos = new Vector3(141, 150, 50);
    Vector3 tres = new Vector3(149, 150, 186);
    Vector3 quatros = new Vector3(-47, 150, 208);

    // Start is called before the first frame update
    void Start()
    {
        one = true;
           two = false;
        three = false;
            four = false;
        transform.position = unos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(25, 0, 150));
        if (one == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, dos, speed * Time.deltaTime);
            if (transform.position.x >= dos.x && transform.position.z >= dos.z)
            {
                one = false;
                two = true;
            }
        }
        if (two == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, tres, speed * Time.deltaTime);
            if(transform.position.x >= tres.x && transform.position.z >= tres.z)
            {
                two = false;
                three = true;
            }
        }
        if (three == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, quatros, speed * Time.deltaTime);
            if (transform.position.x >= quatros.x && transform.position.z >= quatros.z)
            {
                three = false;
                four = true;
            }
        }
        if (four == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, unos, speed * Time.deltaTime);
            if (transform.position.x >= unos.x && transform.position.z >= unos.z)
            {
                four = false;
                one = true;
            }
        }
        
    }
}
