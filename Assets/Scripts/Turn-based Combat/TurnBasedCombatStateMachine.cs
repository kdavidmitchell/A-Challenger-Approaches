using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour 
{

    private bool hasAddedXP = false;
	private BattleStateStart battleStateStartScript = new BattleStateStart();
	private BattleCalculations battleCalculationsScript = new BattleCalculations ();
	private BattleStateAddStatusEffects battleStateAddStatusEffectsScript = new BattleStateAddStatusEffects();
	private BattleStateEnemyTurn battleStateEnemyTurnScript = new BattleStateEnemyTurn();

	public static BaseAbility playerUsedAbility;
	public static BaseAbility enemyUsedAbility;
	public static int statusEffectBaseDamage;
	public static int totalTurnCount;
	public static bool playerCompletedTurn;
	public static bool enemyCompletedTurn;
	public static BattleStates currentTurnOwner;

	public enum BattleStates
	{
		START,
		PLAYER_TURN,
		//player_animate
		ENEMY_TURN,
		//enemy_animate
		CALCULATE_DAMAGE,
		ADD_STATUS_EFFECTS,
		END_TURN,
		LOSE,
		WIN
	}

	public static BattleStates currentState;

	// Use this for initialization
	void Start () 
	{
        hasAddedXP = false;
		totalTurnCount = 1;
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
				currentTurnOwner = BattleStates.PLAYER_TURN;
				break;
			case (BattleStates.ENEMY_TURN):
				currentTurnOwner = BattleStates.ENEMY_TURN;
				battleStateEnemyTurnScript.EnemyTakeTurn ();
				//enemyCompletedTurn = true;
				//CheckTurnOwner ();
				break;
			case (BattleStates.CALCULATE_DAMAGE):
				if (currentTurnOwner == BattleStates.PLAYER_TURN) {
					battleCalculationsScript.CalculateTotalPlayerDamage (playerUsedAbility);
				}
				if (currentTurnOwner == BattleStates.ENEMY_TURN) {
					battleCalculationsScript.CalculateTotalEnemyDamage (enemyUsedAbility);
				}
				CheckTurnOwner ();	
				break;
			case (BattleStates.ADD_STATUS_EFFECTS):
				battleStateAddStatusEffectsScript.CheckAbilityForStatusEffect (playerUsedAbility);
				break;
			case (BattleStates.END_TURN):
				totalTurnCount++;
				playerCompletedTurn = false;
				enemyCompletedTurn = false;
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

	private void CheckTurnOwner()
	{
		if (playerCompletedTurn && !enemyCompletedTurn) {
			//enemy turn
			currentState = BattleStates.ENEMY_TURN;
		} else if (!playerCompletedTurn && enemyCompletedTurn) {
			//player turn
			currentState = BattleStates.PLAYER_TURN;
		} else if (playerCompletedTurn && enemyCompletedTurn) {
			//switch to end turn state
			currentState = BattleStates.END_TURN;
		}
	}

}
