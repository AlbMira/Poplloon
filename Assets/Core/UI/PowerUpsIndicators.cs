using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpsIndicators : MonoBehaviour
{
    public static PowerUpsIndicators Instance { get; private set; }
    [SerializeField] private Image _multipliedIcon;

    private void Awake()
    {
        _multipliedIcon.enabled = false;
        Instance = this;
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
