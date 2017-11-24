using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour 
{

    private bool hasAddedXP = false;
	private BattleStateStart battleStateStartScript = new BattleStateStart();

	public enum BattleStates
	{
		START,
		PLAYER_TURN,
		//player_animate
		ENEMY_TURN,
		//enemy_animate
		CALCULATE_DAMAGE,
		ADD_STATUS_EFFECTS,
		LOSE,
		WIN
	}

	public static BattleStates currentState;

	// Use this for initialization
	void Start () 
	{
        hasAddedXP = false;
		currentState = BattleStates.START;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log(currentState);
		switch (currentState)
		{
			case (BattleStates.START):
				//setup battle function
				//create enemy
				battleStateStartScript.PrepareBattle();
				break;
			case (BattleStates.PLAYER_TURN):
				break;
			case (BattleStates.ENEMY_TURN):
				break;
			case (BattleStates.CALCULATE_DAMAGE):
				break;
			case (BattleStates.ADD_STATUS_EFFECTS):
				break;
			case (BattleStates.LOSE):
				break;
			case (BattleStates.WIN):
                if (!hasAddedXP)
                {
                    Experience.AddExperience();
                    hasAddedXP = true;
                }
				break;
		}	
	}

	void OnGUI()
	{
		if (GUILayout.Button("NEXT STATE"))
		{
			if (currentState == BattleStates.START)
			{
				currentState = BattleStates.PLAYER_TURN;
			}
		}
	}

}
