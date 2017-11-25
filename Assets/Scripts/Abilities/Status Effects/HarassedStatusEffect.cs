using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarassedStatusEffect : BaseStatusEffect 
{

	public HarassedStatusEffect()
	{
		StatusEffectName = "Harassed";
		StatusEffectDescription = "Enemy takes harassment damage over a number of turns.";
		StatusEffectID = 1;
		StatusEffectDamage = 2;
		StatusEffectApplyChance = 100;
		StatusEffectMinTurnApplied = 3;
		StatusEffectMaxTurnApplied = 3;
	}

}
