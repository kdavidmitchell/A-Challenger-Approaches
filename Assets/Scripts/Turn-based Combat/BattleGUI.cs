using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleGUI : MonoBehaviour 
{

	private string playerName;
	private int playerLevel;
	private int playerHealth;
	private int playerEnergy;

	// Use this for initialization
	void Start () 
	{
		playerName = GameInformation.PlayerName;
		playerLevel = GameInformation.PlayerLevel;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
		//buttons for players moves
		//enemy health and other enemy information
		//player health and other info
	}
}
