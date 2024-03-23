using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Entity;

public class PowerUpController : MonoBehaviour
{
    public static PowerUpController Controller;
    public float duration;

    [Space]
    [Header("PowerUp Inputs")]
    public bool slowly;
    public bool multiplied;
    public bool powerUpDisable;

    private void Awake()
    {
        Controller = this;
    }

    private void Start()
    {
        slowly = false;
        multiplied = false;
        powerUpDisable = true;
    }

    private void Update()
    {
        if(slowly || multiplied)
        {
            duration -= Time.deltaTime;
            powerUpDisable = false;

            if(duration < 5f && slowly && !powerUpDisable)
            {
                GameManager.Instance.DoSlowMotion();
            }

            if (duration <= 0f && !powerUpDisable)
            {
                duration = 5f;

                slowly = false;
                multiplied = false;
                powerUpDisable = true;
            }
        }
    }

    public bool CheckCurrentDuration()
    {
        float currentDur = duration;

        return currentDur < 5f;
    }

    public void GetMoreDuration()
    {
        duration += CheckCurrentDuration() ? 5f : 0f;
    }
}
