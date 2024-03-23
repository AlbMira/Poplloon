using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownMenu : Singleton<DropdownMenu>
{
    [SerializeField] private TextMeshProUGUI[] runtimeGameTexts;
    [SerializeField] private Button _dropdownButton;
    [SerializeField] private Button[] _menuButtons;

    private void Update()
    {
        if (_dropdownButton.gameObject.activeSelf)
        {
            foreach (var button in _menuButtons)
            {
                button.gameObject.SetActive(false);
            }

            foreach (var text in runtimeGameTexts)
            {
                text.enabled = true;
            }
        }

        else
        {
            foreach (var button in _menuButtons)
            {
                button.gameObject.SetActive(true);
            }

            foreach (var text in runtimeGameTexts)
            {
                text.enabled = false;
            }
        }
    }

    public void InButtonPressed()
    {
        _dropdownButton.gameObject.SetActive(false);
    }
}
