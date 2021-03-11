using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapPanels : MonoBehaviour
{
    public GameObject audio;
    public GameObject video;



    public void BringAudio()
    {
       

        audio = GameObject.FindGameObjectWithTag("AUDIO");
        video = GameObject.FindGameObjectWithTag("VIDEO");

        audio.gameObject.SetActive(true);
        video.gameObject.SetActive(false);
    }

    public void BringVideo()
    {

        audio = GameObject.FindGameObjectWithTag("AUDIO");
        video = GameObject.FindGameObjectWithTag("VIDEO");

        
        
            video.gameObject.SetActive(true);
            audio.gameObject.SetActive(false);
        
    }

    
}
