using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Walls : MonoBehaviour
{
    public GameObject[] walls;
    bool movement, shoot, rotate;
    public GameObject sound;
    public bool tutorialFinished = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    bool done = false;
    // Update is called once per frame
    void Update()
    {
       
        if (TutorialWall() == true && done == false)
            {
            if (tutorialFinished == false)
                done = true;
                Instantiate(sound, walls[0].transform.position, walls[0].transform.rotation);
                StartCoroutine(DestroyTutorialWall());
            

            }
        

    }

    bool w, a, s, d, lClick;

    bool TutorialWall()
    {
        if (Input.GetKey(KeyCode.W))
            w = true;
        if (Input.GetKey(KeyCode.A))
            a = true;
        if (Input.GetKey(KeyCode.S))
            s = true;
        if (Input.GetKey(KeyCode.D))
            d = true;
        if (Input.GetMouseButton(0))
            lClick = true;


        if (w == true && a == true && s == true && d == true && lClick == true)
        {
            
            return true;
            print("still going");
        }

        else return false;
    }

    IEnumerator DestroyTutorialWall()
    {
        
        int i = 0;
        while (i < 100)
        {
            walls[0].transform.Translate(0, -6.5f * Time.deltaTime, 0);
            i++;
            tutorialFinished = true;
            yield return new WaitForSeconds(0.01f);
        }
        Destroy(walls[0]);

    }

    void PlayWall()
    {
        this.GetComponent<AudioSource>().Play();
    }
}
