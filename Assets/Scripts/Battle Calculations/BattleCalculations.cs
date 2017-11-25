using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCalculations 
{
	private StatCalculations statCalcScript = new StatCalculations();
	private int abilityPower;
	private int statusEffectDamage;
	private float totalAbilityPowerDamage;
	private int totalUsedAbilityDamage;
	private float totalPlayerDamage;

	public void CalculateTotalPlayerDamage(BaseAbility usedAbility)
	{
		totalUsedAbilityDamage = (int)(CalculateAbilityDamage (usedAbility));
		Debug.Log (totalUsedAbilityDamage);
		totalPlayerDamage = totalUsedAbilityDamage + CalculateStatusEffectDamage ();
		TurnBasedCombatStateMachine.playerCompletedTurn = true;
		//TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMY_TURN;

	}

	public void CalculateTotalEnemyDamage(BaseAbility usedAbility)
	{
		totalUsedAbilityDamage = (int)(CalculateAbilityDamage (usedAbility));
		Debug.Log (totalUsedAbilityDamage);
		totalPlayerDamage = totalUsedAbilityDamage + CalculateStatusEffectDamage ();
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
}
