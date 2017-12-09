using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleFunctions : MonoBehaviour 
{

	//Player information
	private Text playerName;
	private int playerLevel;
	private Text playerHealth;
	private Image playerHealthImage;
	private Text playerEnergy;
	private Image playerEnergyImage;

	public float playerCurrentHealth;
	public float playerCurrentEnergy;

	private Text abilityOneName;
	private Text abilityTwoName;

	//Enemy information
	private Text enemyName;
	private int enemyLevel;
	private Text enemyHealth;
	private Image enemyHealthImage;
	private Text enemyEnergy;
	private Image enemyEnergyImage;

	private float enemyMaxHealth;
	public float enemyCurrentHealth; 
	private float enemyMaxEnergy;
	public float enemyCurrentEnergy;

	private BattleStateStart battleStateStartScript = new BattleStateStart();

	// Use this for initialization
	void Start () 
	{
		LoadInformation.LoadAllInformation();

		playerName = GameObject.Find ("PlayerName").GetComponent<Text>();
		playerHealth = GameObject.Find ("PlayerHealthValue").GetComponent<Text>();
		playerHealthImage = GameObject.Find ("PlayerHealthBar").GetComponent<Image>();
		playerEnergy = GameObject.Find ("PlayerEnergyValue").GetComponent<Text>();
		playerEnergyImage = GameObject.Find ("PlayerEnergyBar").GetComponent<Image>();

		enemyName = GameObject.Find ("EnemyName").GetComponent<Text>();
		enemyHealth = GameObject.Find ("EnemyHealthValue").GetComponent<Text>();
		enemyHealthImage = GameObject.Find ("EnemyHealthBar").GetComponent<Image>();
		enemyEnergy = GameObject.Find ("EnemyEnergyValue").GetComponent<Text>();
		enemyEnergyImage = GameObject.Find ("EnemyEnergyBar").GetComponent<Image>();

		battleStateStartScript.DeterminePlayerVitals();
		playerName.text = GameInformation.PlayerName;
		playerCurrentHealth = GameInformation.PlayerHealth;
		playerCurrentEnergy = GameInformation.PlayerEnergy;
		playerHealth.text = playerCurrentHealth.ToString();
		playerEnergy.text = playerCurrentEnergy.ToString();

		battleStateStartScript.CreateNewEnemy();
		enemyName.text = battleStateStartScript.newEnemy.PlayerName;
		enemyCurrentHealth = battleStateStartScript.enemyCurrentHealth;
		enemyMaxHealth = enemyCurrentHealth;
		enemyCurrentEnergy = battleStateStartScript.enemyCurrentEnergy;
		enemyMaxEnergy = enemyCurrentEnergy;
		enemyHealth.text = enemyCurrentHealth.ToString();
		enemyEnergy.text = enemyCurrentEnergy.ToString();
	}
	
	// Update is called once per frame
	void Update () 
	{
		playerHealth.text = playerCurrentHealth.ToString();
		playerEnergy.text = playerCurrentEnergy.ToString();
		playerHealthImage.fillAmount = playerCurrentHealth / GameInformation.PlayerMaxHealth;
		playerEnergyImage.fillAmount = playerCurrentEnergy / GameInformation.PlayerMaxEnergy;

		enemyHealth.text = enemyCurrentHealth.ToString();
		enemyEnergy.text = enemyCurrentEnergy.ToString();
		enemyHealthImage.fillAmount = enemyCurrentHealth / enemyMaxHealth;
		enemyEnergyImage.fillAmount = enemyCurrentEnergy / enemyMaxEnergy;
	}

	public void MeleeAbilityOne()
	 {
	 	TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.PlayerMove1;
		TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATE_DAMAGE;
	 }

	 public void MeleeAbilityTwo()
	 {
	 	TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.PlayerMove2;
		TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ADD_STATUS_EFFECTS;
	 }

	 public void FindAbilityInfo()
	{
		abilityOneName = GameObject.Find("A1Text").GetComponent<Text>();
		abilityOneName.text = GameInformation.PlayerMove1.AbilityName;

		abilityTwoName = GameObject.Find("A2Text").GetComponent<Text>();
		abilityTwoName.text = GameInformation.PlayerMove2.AbilityName;
	}
}
