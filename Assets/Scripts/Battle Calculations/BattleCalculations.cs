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
	}

	public void CalculatePlayerUsedAbilityDamage(BaseAbility usedAbility)
	{

		//use an ability
		//calculate damage
		//check status effect
			//if the move has a status effect
				//try to add effect
				//if effect is added then apply damage from effect
		//calculate total damage with status effect in mind
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
