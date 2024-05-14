using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : Singleton<App>
{
    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            AppExit();
        }
    }

    public void AppExit()
    {
        Application.Quit();
        Debug.Log("is Exit");
    }
}
