using UnityEngine;

public class MuteSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;

    public void onClick()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource2 = GameObject.Find("Player").GetComponent<AudioSource>();
        if (audioSource.volume == 0)
        {
            audioSource.volume = 0.1f;
        }
        else
        {
            audioSource.volume = 0;
        }
        if (audioSource2.volume == 0)
        {
            audioSource2.volume = 0.1f;
        }
        else
        {
            audioSource2.volume = 0;
        }
    }
}

