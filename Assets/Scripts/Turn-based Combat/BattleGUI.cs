using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleGUI : MonoBehaviour 
{
	private Text playerName;
	private Text playerHealth;
	private Image playerHealthImage;
	//private string playerName;
	private int playerLevel;
	//private int playerHealth;
	private int playerEnergy;

	private Text abilityOneName;
	private Text abilityTwoName;

	// Use this for initialization
	void Start () 
	{
		playerName = GameObject.Find ("PlayerName").GetComponent<Text>();
		//GameInformation.PlayerName = "Test";

		playerHealth = GameObject.Find ("PlayerHealthValue").GetComponent<Text>();
		playerHealthImage = GameObject.Find ("PlayerHealthBar").GetComponent<Image> ();

		//playerName = GameInformation.PlayerName;
		playerLevel = GameInformation.PlayerLevel;
	}
	
	// Update is called once per frame
	void Update () 
	{
		playerHealth.text = GameInformation.PlayerHealth.ToString ();
		playerName.text = GameInformation.PlayerName;
	}

	void OnGUI()
	{
		if (TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.PLAYER_TURN) 
		{
			DisplayPlayerChoices ();
		}
		//enemy health and other enemy information
		//player health and other info
	}

	 public void MeleeAbilityOne()
	 {
	 	TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.PlayerMove1;
		TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ADD_STATUS_EFFECTS;
	 }

	 public void MeleeAbilityTwo()
	 {
	 	TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.PlayerMove2;
		TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ADD_STATUS_EFFECTS;
	 }

	private void DisplayPlayerChoices()
	{
		//buttons for players moves
		if (GUI.Button (new Rect (Screen.width - 150, Screen.height - 50, 100, 30), GameInformation.PlayerMove2.AbilityName)) 
		{
			//calculate the players damage to the enemy
			TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.PlayerMove2;
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ADD_STATUS_EFFECTS;
		}
		if (GUI.Button (new Rect (Screen.width - 250, Screen.height - 50, 100, 30), GameInformation.PlayerMove1.AbilityName)) 
		{
			//calculate the players damage to the enemy
			TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.PlayerMove1;
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ADD_STATUS_EFFECTS;
		}
	}

	public void FindAbilityInfo()
	{
		abilityOneName = GameObject.Find("A1Text").GetComponent<Text>();
		abilityOneName.text = GameInformation.PlayerMove1.AbilityName;

		abilityTwoName = GameObject.Find("A2Text").GetComponent<Text>();
		abilityTwoName.text = GameInformation.PlayerMove2.AbilityName;
	}
}
