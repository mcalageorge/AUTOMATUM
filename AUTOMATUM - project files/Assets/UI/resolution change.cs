using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resolutionchange : MonoBehaviour
{
    void ChangeTo720p()
    {
        Screen.SetResolution(1280, 720, true);
    }
    void ChangeTo1080p()
    {
        Screen.SetResolution(1920, 1080, true);
    }

}
