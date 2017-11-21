using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp
{

    private int maxPlayerLevel = 5;

	public void LevelUpCharacter()
    {
        //check to see if current xp > required xp
        if (GameInformation.CurrentXP > GameInformation.RequiredXP)
        {
            GameInformation.CurrentXP -= GameInformation.RequiredXP;
        }
        else
        {
            GameInformation.CurrentXP = 0;
        }

        if (GameInformation.PlayerLevel < maxPlayerLevel)
        {
            GameInformation.PlayerLevel++;
        }
        else
        {
            GameInformation.PlayerLevel = maxPlayerLevel;
        }
        //give player stat points
        //randomly give items
        //level up their abilities
        //give money
        //determine next required amount of xp
        DetermineRequiredXP();
    }

    private void DetermineRequiredXP()
    {
        float temp = GameInformation.PlayerLevel * 50 + 25;
        GameInformation.RequiredXP = temp;
    }
}
