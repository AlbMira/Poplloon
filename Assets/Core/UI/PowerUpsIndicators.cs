using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpsIndicators : Singleton<PowerUpsIndicators>
{
    [SerializeField] private Image _multipliedIcon;

    private void Awake()
    {
        _multipliedIcon.enabled = false;
    }

    private void Update()
    {
        if (PowerUpController.Controller.multiplied)
        {
            _multipliedIcon.enabled = true;
        }

        else
        {
            _multipliedIcon.enabled = false;
        }
    }
}
