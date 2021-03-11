using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSound : MonoBehaviour
{
    public GameObject sounding;
    // Start is called before the first frame update
    void Instantiate()
    {
        Instantiate(sounding);
    }
}
