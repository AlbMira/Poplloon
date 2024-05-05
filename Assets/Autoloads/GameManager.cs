using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Attributes;
using Poplloon.main;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public ColorData _colorBlind;

    [Space]
    [Header("Color Data Sets")]
    public ColorDataSet _dataColor;

    [Space]
    [Header("Mesh Sets")]
    public MeshSet _tailSet;
    public MeshSet _teddySet;

    [Space]
    [Header("Color Manager")]
    public Color currentColor;
    public float colorTimer;
    public float changeInstanceColor;

    [Space]
    [Header("Time Manager")]
    public float slowDownFactor;
    public float slowDownLength;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _dataColor.SetColorSet();
        _colorBlind = _dataColor._dataSet[SetFilterController.colorBlindFilters[MainMenuController.indexFilter]];

        SetCurrentColor();
    }

    private void Update()
    {
        colorTimer -= Time.deltaTime;
        changeInstanceColor -= Time.deltaTime;

        Time.timeScale += (1f / slowDownLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

    public void SetCurrentColor()
    {
        //Get the current random color
        currentColor = _colorBlind.GetColor();
    }

    public void DoSlowMotion()
    {
        Time.timeScale = slowDownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }
}
