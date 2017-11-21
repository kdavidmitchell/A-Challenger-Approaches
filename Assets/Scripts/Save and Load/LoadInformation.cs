using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation
{

	public static void LoadAllInformation()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYER_NAME");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYER_LEVEL");
        GameInformation.Rhetoric = PlayerPrefs.GetInt("PLAYER_RHETORIC");
        GameInformation.Image = PlayerPrefs.GetInt("PLAYER_IMAGE");
        GameInformation.Diplomacy = PlayerPrefs.GetInt("PLAYER_DIPLOMACY");
        GameInformation.CurrentXP = PlayerPrefs.GetFloat("PLAYER_CURRENTXP");
        GameInformation.RequiredXP = PlayerPrefs.GetFloat("PLAYER_REQUIREDXP");
        GameInformation.Currency = PlayerPrefs.GetInt("PLAYER_CURRENCY");

        if (PlayerPrefs.GetString("PLAYER_SKILLS") != null)
        {
            GameInformation.PlayerSkills = (List<Skill>)PPSerialization.Load("PLAYER_SKILLS");
        }

        if (PlayerPrefs.GetString("CLOTHING_1") != null)
        {
        	GameInformation.Clothing1 = (BaseClothing)PPSerialization.Load("CLOTHING_1");
        }
    }
}
