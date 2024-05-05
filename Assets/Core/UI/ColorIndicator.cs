using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Poplloon.Attributes;
using UnityEditor.PackageManager;

public class ColorIndicator : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textColor;
    [SerializeField] private TextMeshProUGUI _currentColor;

    void Start()
    {
        _textColor = GameManager.Instance._dataColor._label;

        SetLabel();
    }

    void FixedUpdate()
    {
        //Timer will change the current color when it will be 0
        _currentColor.text = GameManager.Instance.colorTimer.ToString("F0");

        if (GameManager.Instance.colorTimer <= 0f)
        {
            GameManager.Instance.SetCurrentColor();
            SetLabel();
            GameManager.Instance.colorTimer += 10f;
        }
    }

    public void SetLabel()
    {
        //It marks which is the new current color in the UI
        _textColor.color = GameManager.Instance.currentColor;
        
        _textColor.text = GameManager.Instance._colorBlind.GetPair(_textColor.color).Key;
    }
}
