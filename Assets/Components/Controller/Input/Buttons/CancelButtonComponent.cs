using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelButtonComponent : MonoBehaviour
{
    [SerializeField] private Button _dropDownButton;

    public void InButtonPressed()
    {
        _dropDownButton.gameObject.SetActive(true);
    }
}
