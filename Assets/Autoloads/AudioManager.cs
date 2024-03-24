using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    [Header("Audio Source and Clips library")]
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public AudioClip currentClip;
    public int index;

    public void PlayClip()
    {
        audioSource.PlayOneShot(SetClip());
    }

    public AudioClip SetClip() => currentClip = audioClips[index];
}
