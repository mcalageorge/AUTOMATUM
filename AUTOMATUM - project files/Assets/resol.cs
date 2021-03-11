using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resol : MonoBehaviour
{
    public void ChangeTo720p()
    {
        Screen.SetResolution(1280, 720, true);
    }
    public void ChangeTo1080p()
    {
        Screen.SetResolution(1920, 1080, true);
    }
}
