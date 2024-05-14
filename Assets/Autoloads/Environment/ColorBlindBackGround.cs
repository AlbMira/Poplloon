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

            case 2:
                backGroundColor = new Color(0.3647059f, 0.4352941f, 0.5803922f, 1);
                break;

            case 3:
                backGroundColor = new Color(0f, 0.9098039f, 0.8078431f, 1);
                break;

            case 4:
                backGroundColor = new Color(0.7254902f, 0.7254902f, 0.7254902f, 1);
                break;

            default:
                backGroundColor = Color.white;
                break;
        }

        return backGroundColor;
    }
}
