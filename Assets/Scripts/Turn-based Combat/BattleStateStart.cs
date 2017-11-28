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
	private float playerMaxHealth;
	private float playerMaxEnergy;

	private int enemyDiplomacy;
	private int enemyRhetoric;
	public float enemyMaxHealth;
	public float enemyMaxEnergy;
	public float enemyCurrentHealth;
	public float enemyCurrentEnergy;

	public void PrepareBattle()
	{
		//create enemy
		//CreateNewEnemy();
		//DeterminePlayerVitals();
		//player goes first
		TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.PLAYER_TURN;
	}

	public void CreateNewEnemy()
	{
		newEnemy.PlayerName = enemyNames[Random.Range(0, enemyNames.Length - 1)];
		newEnemy.PlayerLevel = GameInformation.PlayerLevel;
		newEnemy.PlayerClass = classTypes [Random.Range (0, classTypes.Length - 1)];
		newEnemy.Rhetoric = statCalculations.CalculateStat (newEnemy.PlayerClass.Rhetoric, StatCalculations.StatType.RHETORIC, newEnemy.PlayerLevel, true);
		newEnemy.Image = statCalculations.CalculateStat (newEnemy.PlayerClass.Image, StatCalculations.StatType.IMAGE, newEnemy.PlayerLevel, true);
		newEnemy.Diplomacy = statCalculations.CalculateStat (newEnemy.PlayerClass.Diplomacy, StatCalculations.StatType.DIPLOMACY, newEnemy.PlayerLevel, true);
		
		enemyMaxHealth = statCalculations.CalculateHealth (newEnemy.Diplomacy);
		enemyMaxEnergy = statCalculations.CalculateEnergy (newEnemy.Rhetoric);
		enemyCurrentHealth = enemyMaxHealth;
		enemyCurrentEnergy = enemyMaxEnergy;
	}

	public void DeterminePlayerVitals()
	{
		//testing purposes
		/*GameInformation.PlayerName = "Test";
		GameInformation.PlayerClass = new BaseGladhanderClass ();
		GameInformation.Rhetoric = GameInformation.PlayerClass.Rhetoric;
		GameInformation.Image = GameInformation.PlayerClass.Image;
		GameInformation.Diplomacy = GameInformation.PlayerClass.Diplomacy;*/

		playerDiplomacy = statCalculations.CalculateStat (GameInformation.Diplomacy, StatCalculations.StatType.DIPLOMACY, GameInformation.PlayerLevel, false);
		playerRhetoric = statCalculations.CalculateStat (GameInformation.Rhetoric, StatCalculations.StatType.RHETORIC, GameInformation.PlayerLevel, false);
	
		playerMaxHealth = statCalculations.CalculateHealth (playerDiplomacy);
		playerMaxEnergy = statCalculations.CalculateEnergy (playerRhetoric);

		GameInformation.PlayerMaxHealth = playerMaxHealth;
		GameInformation.PlayerHealth = playerMaxHealth;
		GameInformation.PlayerMaxEnergy = playerMaxEnergy;
		GameInformation.PlayerEnergy = playerMaxEnergy;
	}

}
