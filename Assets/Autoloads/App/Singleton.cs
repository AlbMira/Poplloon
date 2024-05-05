using System.Collections;
using System.Collections.Generic;
using Poplloon.Audio;
using UnityEngine;

public class Singleton<T> : MonoBehaviour  
{
    public static Singleton<T> Instance;

    private void Awake()
    {
        if (Singleton<T>.Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else { Destroy(gameObject); }
    }
}
