using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Attributes; 

public class Reward : MonoBehaviour
{
    public static Reward reward;

    private void Awake()
    {
        reward = this;
    }

    public bool IsValid(Color valuableColor)
    {
        //Return a color value to this method
        return valuableColor == GameManager.Instance.currentColor;
    }
    
    public void Revenue(Color revenue)
    {
        //Compare if the color value of the balloons is equal to the color indicator, add 500 to score if it is true, else subtract
        if(PowerUpController.Controller.multiplied)
        {
            ScoreSystem.Instance._score += IsValid(revenue) ? 1000 : -500;
        }

        ScoreSystem.Instance._score += IsValid(revenue) ? 500 : -500;
    }
}
