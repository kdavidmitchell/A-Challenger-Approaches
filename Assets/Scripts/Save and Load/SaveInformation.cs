﻿using System.Collections;
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


        if (GameInformation.Clothing1 != null)
    	{
    		PPSerialization.Save("CLOTHING_1", GameInformation.Clothing1);
    	}
        Debug.Log("SAVED ALL INFORMATION.");
    }
}
