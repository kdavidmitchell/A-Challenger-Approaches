using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCalculations 
{
	private StatCalculations statCalcScript = new StatCalculations();
	private TurnBasedCombatStateMachine tbcsm;
	private int abilityPower;
	private int statusEffectDamage;
	private float totalAbilityPowerDamage;
	private int totalUsedAbilityDamage;
	public float totalPlayerDamage;
	public float energyCost;

	public void CalculateTotalPlayerDamage(BaseAbility usedAbility)
	{
		tbcsm = GameObject.Find("BattleManager").GetComponent<TurnBasedCombatStateMachine>();

		totalUsedAbilityDamage = (int)(CalculateAbilityDamage (usedAbility));
		Debug.Log (totalUsedAbilityDamage);
		totalPlayerDamage = totalUsedAbilityDamage + CalculateStatusEffectDamage ();
		Debug.Log(totalPlayerDamage);
		TurnBasedCombatStateMachine.battleFunctionsScript.enemyCurrentHealth -= totalPlayerDamage;
		TurnBasedCombatStateMachine.battleFunctionsScript.UpdateDisplayedInfo();
		TurnBasedCombatStateMachine.playerCompletedTurn = true;
		//TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMY_TURN;

	}

	public void CalculateTotalEnemyDamage(BaseAbility usedAbility)
	{
		tbcsm = GameObject.Find("BattleManager").GetComponent<TurnBasedCombatStateMachine>();

		totalUsedAbilityDamage = (int)(CalculateAbilityDamage (usedAbility));
		Debug.Log (totalUsedAbilityDamage);
		totalPlayerDamage = totalUsedAbilityDamage + CalculateStatusEffectDamage ();
		TurnBasedCombatStateMachine.battleFunctionsScript.playerCurrentHealth -= totalPlayerDamage;
		TurnBasedCombatStateMachine.battleFunctionsScript.UpdateDisplayedInfo();
		TurnBasedCombatStateMachine.enemyCompletedTurn = true;
		//TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMY_TURN;

	}

	private float CalculateAbilityDamage(BaseAbility usedAbility)
	{
		abilityPower = usedAbility.AbilityDamage; //retrieves power of move
		totalAbilityPowerDamage = abilityPower + statCalcScript.FindPlayerMainStatAndCalculateMainStatModifier();
		return totalAbilityPowerDamage;
	}

	private int CalculateStatusEffectDamage()
	{
		return statusEffectDamage = TurnBasedCombatStateMachine.statusEffectBaseDamage;
	}

	public void GetEnergyCost(BaseAbility usedAbility)
	{
		tbcsm = GameObject.Find("BattleManager").GetComponent<TurnBasedCombatStateMachine>();
		
		energyCost = usedAbility.AbilityCost;
		TurnBasedCombatStateMachine.battleFunctionsScript.playerCurrentEnergy -= energyCost;
		TurnBasedCombatStateMachine.battleFunctionsScript.UpdateDisplayedInfo();
	}
}
