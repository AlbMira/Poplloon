using System.Collections;
using System.Collections.Generic;
using Poplloon.main;
using UnityEngine;

public class ColorBlindBackGround : Singleton<ColorBlindBackGround>
{
    public int colorBlindIndex;

    private void LateUpdate()
    {
        colorBlindIndex = MainMenuController.indexFilter;

        this.gameObject.GetComponent<SpriteRenderer>().color = ColorBlindBackgroundColor();
    }

    public Color ColorBlindBackgroundColor()
    {
        Color backGroundColor;

        switch (colorBlindIndex)
        {
            case 1:
                backGroundColor = new Color(0.4f, 0.5333334f, 0.8156863f, 1);
                break;

            default:
                backGroundColor = Color.white;
                break;
        }

        return backGroundColor;
    }
}
