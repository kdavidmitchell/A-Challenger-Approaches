using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SleepStatusEffect : BaseStatusEffect
{

	public SleepStatusEffect()
	{
		StatusEffectName = "Sleep";
		StatusEffectDescription = "Enemy falls asleep for a number of turns.";
		StatusEffectID = 2;
		StatusEffectDamage = 0;
		StatusEffectApplyChance = 100;
		StatusEffectMinTurnApplied = 2;
		StatusEffectMaxTurnApplied = 3;
	}
}
