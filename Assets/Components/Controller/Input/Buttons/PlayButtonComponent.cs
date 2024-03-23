using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonComponent : Singleton<PlayButtonComponent>
{
    public void InButtonPressed()
    {
        SceneManager.LoadScene("Play");
    }
}
