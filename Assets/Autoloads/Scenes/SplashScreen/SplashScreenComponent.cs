using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SplashScreenComponent : MonoBehaviour
{
    private void Start()
    {
        var vid = this.gameObject.GetComponent<VideoPlayer>();

        vid.loopPointReached += CheckOver;
    }

    public void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("Main");
    }
}
