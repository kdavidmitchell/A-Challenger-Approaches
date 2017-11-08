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
    }
}
