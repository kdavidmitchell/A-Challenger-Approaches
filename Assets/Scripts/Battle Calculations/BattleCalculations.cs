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
	public float totalPlayerDamage;
	public float energyCost;

	public int CalculateTotalPlayerDamage(BaseAbility usedAbility)
	{

		totalUsedAbilityDamage = (int)(CalculateAbilityDamage (usedAbility));
		Debug.Log (totalUsedAbilityDamage);
		totalPlayerDamage = totalUsedAbilityDamage + CalculateStatusEffectDamage ();
		TurnBasedCombatStateMachine.playerCompletedTurn = true;
		
		return (int)totalPlayerDamage;
	}

	public int CalculateTotalEnemyDamage(BaseAbility usedAbility)
	{

		totalUsedAbilityDamage = (int)(CalculateAbilityDamage (usedAbility));
		Debug.Log (totalUsedAbilityDamage);
		totalPlayerDamage = totalUsedAbilityDamage + CalculateStatusEffectDamage ();
		TurnBasedCombatStateMachine.enemyCompletedTurn = true;
		
		return (int)totalPlayerDamage;
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

	public float GetEnergyCost(BaseAbility usedAbility)
	{
		
		energyCost = usedAbility.AbilityCost;

		return energyCost;
	}
}
