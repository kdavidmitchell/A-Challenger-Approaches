using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation
{

	public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PLAYER_LEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetString("PLAYER_NAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("PLAYER_RHETORIC", GameInformation.Rhetoric);
        PlayerPrefs.SetInt("PLAYER_IMAGE", GameInformation.Image);
        PlayerPrefs.SetInt("PLAYER_DIPLOMACY", GameInformation.Diplomacy);
        PlayerPrefs.SetFloat("PLAYER_CURRENTXP", GameInformation.CurrentXP);
        PlayerPrefs.SetFloat("PLAYER_REQUIREDXP", GameInformation.RequiredXP);
        PlayerPrefs.SetInt("PLAYER_CURRENCY", GameInformation.Currency);

        if (GameInformation.PlayerSkills != null)
        {
            PPSerialization.Save("PLAYER_SKILLS", GameInformation.PlayerSkills);
        }

        if (GameInformation.Clothing1 != null)
    	{
    		PPSerialization.Save("CLOTHING_1", GameInformation.Clothing1);
    	}
        
        Debug.Log("SAVED ALL INFORMATION.");
        Debug.Log(GameInformation.PlayerClass.CharacterClassName);
        Debug.Log(GameInformation.PlayerName);
    }
}
