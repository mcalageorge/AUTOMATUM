using UnityEngine.Audio;
using UnityEngine;

[SerializeField]
public class Sounds : MonoBehaviour
{
    public AudioClip[] aclip;
    public AudioSource audioPlayer;
    
    void Start()
    {
        audioPlayer = this.GetComponent<AudioSource>();
    }

    public void Update()
    {
        
    }

    public void PlaySound(int sound)
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioPlayer.clip = aclip[sound];
            audioPlayer.PlayOneShot(audioPlayer.clip, 3f);
        }
    }

    

    
}
