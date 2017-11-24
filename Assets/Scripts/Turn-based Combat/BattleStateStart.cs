using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateStart 
{

	public BasePlayer newEnemy = new BasePlayer();
	private StatCalculations statCalculations = new StatCalculations();
	private string[] enemyNames = new string[] { "Underqualified Servant", "Lazy Governor", "Bumbling Bureaucrat" };
	private BaseCharacterClass[] classTypes = new BaseCharacterClass[] {new BaseGladhanderClass(), new BaseChiefClass(), new BaseSophistClass()};

	private int playerDiplomacy;
	private int playerRhetoric;
	private int playerHealth;
	private int playerEnergy;

	public void PrepareBattle()
	{
		//create enemy
		CreateNewEnemy();
		//player goes first
		TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.PLAYER_TURN;
	}

	private void CreateNewEnemy()
	{
		newEnemy.PlayerName = enemyNames[Random.Range(0, enemyNames.Length - 1)];
		newEnemy.PlayerLevel = GameInformation.PlayerLevel;
		newEnemy.PlayerClass = classTypes [Random.Range (0, classTypes.Length - 1)];
		newEnemy.Rhetoric = statCalculations.CalculateStat (newEnemy.Rhetoric, StatCalculations.StatType.RHETORIC, newEnemy.PlayerLevel, true);
		newEnemy.Image = statCalculations.CalculateStat (newEnemy.Image, StatCalculations.StatType.IMAGE, newEnemy.PlayerLevel, true);
		newEnemy.Diplomacy = statCalculations.CalculateStat (newEnemy.Diplomacy, StatCalculations.StatType.DIPLOMACY, newEnemy.PlayerLevel, true);
	}

	private void DeterminePlayerVitals()
	{
		playerDiplomacy = statCalculations.CalculateStat (GameInformation.Diplomacy, StatCalculations.StatType.DIPLOMACY, GameInformation.PlayerLevel, false);
		playerRhetoric = statCalculations.CalculateStat (GameInformation.Rhetoric, StatCalculations.StatType.RHETORIC, GameInformation.PlayerLevel, false);
	
		playerHealth = statCalculations.CalculateHealth (playerDiplomacy);
		playerEnergy = statCalculations.CalculateEnergy (playerRhetoric);

		GameInformation.PlayerHealth = playerHealth;
		GameInformation.PlayerEnergy = playerEnergy;
	}

}
