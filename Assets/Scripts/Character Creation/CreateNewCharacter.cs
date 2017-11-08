using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour
{

    private BasePlayer newPlayer;
    private bool isGladHander;
    private bool isChief;
    private bool isSophist;
    private BaseCharacterClass class1 = new BaseGladhanderClass();
    private BaseCharacterClass class2 = new BaseSophistClass();
    private BaseCharacterClass class3 = new BaseChiefClass();

    private string playerName = "Enter your name here.";

    // Use this for initialization
    void Start ()
    {
        newPlayer = new BasePlayer();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescription);
        GUILayout.Label("Rhetoric: " + class1.Rhetoric.ToString());
        GUILayout.Label("Image : " + class1.Image.ToString());
        GUILayout.Label("Diplomacy: " + class1.Diplomacy.ToString());

        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescription);
        GUILayout.Label("Rhetoric: " + class2.Rhetoric.ToString());
        GUILayout.Label("Image : " + class2.Image.ToString());
        GUILayout.Label("Diplomacy: " + class2.Diplomacy.ToString());

        GUILayout.Label(class3.CharacterClassName);
        GUILayout.Label(class3.CharacterClassDescription);
        GUILayout.Label("Rhetoric: " + class3.Rhetoric.ToString());
        GUILayout.Label("Image : " + class3.Image.ToString());
        GUILayout.Label("Diplomacy: " + class3.Diplomacy.ToString());

        playerName = GUILayout.TextArea(playerName, 20);

        isGladHander = GUILayout.Toggle(isGladHander, "Gladhander");
        isChief = GUILayout.Toggle(isChief, "Chief-of-Staff");
        isSophist = GUILayout.Toggle(isSophist, "Sophist");

        if (GUILayout.Button("Create"))
        {
            if (isGladHander)
            {
                newPlayer.PlayerClass = new BaseGladhanderClass();
            } else if (isChief)
            {
                newPlayer.PlayerClass = new BaseChiefClass();
            } else
            {
                newPlayer.PlayerClass = new BaseSophistClass();
            }

            newPlayer.PlayerName = playerName;
            newPlayer.PlayerLevel = 1;
            newPlayer.Rhetoric = newPlayer.PlayerClass.Rhetoric;
            newPlayer.Image = newPlayer.PlayerClass.Image;
            newPlayer.Diplomacy = newPlayer.PlayerClass.Diplomacy;

            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();

            Debug.Log("Player Name: " + newPlayer.PlayerName);
            Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("Player Level: " + newPlayer.PlayerLevel);
            Debug.Log("Player Rhetoric: " + newPlayer.Rhetoric);
            Debug.Log("Player Image: " + newPlayer.Image);
            Debug.Log("Player Diplomacy: " + newPlayer.Diplomacy);
        }
    }

    private void StoreNewPlayerInfo()
    {
        GameInformation.PlayerName = newPlayer.PlayerName;
        GameInformation.PlayerLevel = newPlayer.PlayerLevel;
        GameInformation.Rhetoric = newPlayer.Rhetoric;
        GameInformation.Image = newPlayer.Image;
        GameInformation.Diplomacy = newPlayer.Diplomacy;
    }
}
