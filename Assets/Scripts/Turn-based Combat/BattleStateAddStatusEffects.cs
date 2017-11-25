using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateAddStatusEffects 
{

	public void CheckAbilityForStatusEffect(BaseAbility usedAbility)
	{
		switch (usedAbility.AbilityStatusEffect.StatusEffectName) 
		{
			case ("Harassed"):
				if (ApplyStatusEffect (usedAbility)) 
				{
					TurnBasedCombatStateMachine.statusEffectBaseDamage = usedAbility.AbilityStatusEffect.StatusEffectDamage;
				} else 
				{
					TurnBasedCombatStateMachine.statusEffectBaseDamage = 0;
				}
				TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATE_DAMAGE;
				
				break;

			default:
				Debug.LogError ("error in status effects");
				break;
		}
	}

	private bool ApplyStatusEffect(BaseAbility usedAbility)
	{
		int randomTemp = Random.Range (1, 100);
		if (randomTemp <= usedAbility.AbilityStatusEffect.StatusEffectApplyChance) 
		{
			return true;
		}

		return false;
	}
}
