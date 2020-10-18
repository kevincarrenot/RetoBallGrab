using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public SoundSystem instance;
    public AudioClip audScore;
    public AudioClip audDeath;
    public AudioClip audGameover;

    public AudioSource audSource;

    public void AudioScore()
    {
        PlayAudio(audScore);
    }

    public void AudioVida()
    {

        PlayAudio(audDeath);
    }

    public void AudioGameover()
    {

        PlayAudio(audGameover);
    }

    private void PlayAudio(AudioClip audioplay)
    {
        audSource.clip = audioplay;
        audSource.Play();
    }
    // Update is called once per frame
    
}
