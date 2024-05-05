using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Poplloon.Audio
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance { get; private set; }
        [Header("Audio Sources")]
        public AudioSource audioSource;
        public AudioSource musicSource;
        public float startVolume = 1f;

        [Space]
        [Header("Audio Clips Library")]
        public AudioClip[] audioClips;
        public AudioClip currentClip;

        private void Awake()
        {
            if (AudioManager.Instance == null)
            {
                Instance = this;
            }

            else { Destroy(gameObject); }
        }

        public void PlayClip(int index)
        {
            audioSource.PlayOneShot(SetClip(index));
            audioSource.pitch = UnityEngine.Random.Range(1f, 1.2f);
        }

        public AudioClip SetClip(int index) => currentClip = audioClips[index];

        public void PlayMainTheme()
        {
            musicSource.PlayOneShot(SetClip(2));
        }
    }

}
