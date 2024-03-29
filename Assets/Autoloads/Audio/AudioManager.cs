using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Poplloon.Audio
{
    public class AudioManager : Singleton<AudioManager>
    {
        [Header("Audio Source and Clips library")]
        public AudioSource audioSource;
        public AudioClip[] audioClips;
        public AudioClip currentClip;

        public void PlayClip(int index)
        {
            audioSource.PlayOneShot(SetClip(index));
            audioSource.pitch = UnityEngine.Random.Range(1f, 1.2f);
        }

        public AudioClip SetClip(int index) => currentClip = audioClips[index];
    }

}
