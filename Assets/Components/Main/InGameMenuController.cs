using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using Poplloon.RayCast;

public class InGameMenuController : Singleton<InGameMenuController>
{
    [SerializeField] private TextMeshProUGUI[] _advicersPlayTextActive;
    [SerializeField] private Button _dropDownButtonActive;
    [SerializeField] private Button[] _inGameElementsActive;
    [SerializeField] private GameObject _inputManager;
    [SerializeField] private bool _activeDeactive;


    private void Start()
    {
        _inputManager.SetActive(true);

        foreach (var buttons in _inGameElementsActive)
        {
            buttons.gameObject.SetActive(false);
        }
    }

    public void DisplayInGameMenu()
    {
        foreach (var texts in _advicersPlayTextActive)
        {
            texts.enabled = false;
        }

        _inputManager.SetActive(false);
        _dropDownButtonActive.enabled = false;

        foreach (var buttons in _inGameElementsActive)
        {
            buttons.gameObject.SetActive(true);
        }

        _dropDownButtonActive.gameObject.SetActive(false);
    }

    public void CloseInGameMenu()
    {
        foreach (var texts in _advicersPlayTextActive)
        {
            texts.enabled = true;
        }

        _inputManager.SetActive(true);
        _dropDownButtonActive.enabled = true;

        foreach (var buttons in _inGameElementsActive)
        {
            buttons.gameObject.SetActive(false);
        }

        _dropDownButtonActive.gameObject.SetActive(true);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main");
    }
}
