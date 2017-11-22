using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Experience
{

    private static float xpToGive;
    private static LevelUp levelUpScript = new LevelUp();

	public static void AddExperience()
    {
        xpToGive = GameInformation.PlayerLevel * 10;
        GameInformation.CurrentXP += xpToGive;
    }

    private static void CheckIfPlayerLeveled()
    {
        if (GameInformation.CurrentXP >= GameInformation.RequiredXP)
        {
            //then the player has leveled up
            levelUpScript.LevelUpCharacter();
            //create level up script
        }
    }
}
