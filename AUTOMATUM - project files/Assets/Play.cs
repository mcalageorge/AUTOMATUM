using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    AudioSource music;
    public GameObject select;
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic()
    {
        music.Play();
    }
    public void SelectSound()
    {
        Instantiate(select, transform.position, transform.rotation);
    }
}
