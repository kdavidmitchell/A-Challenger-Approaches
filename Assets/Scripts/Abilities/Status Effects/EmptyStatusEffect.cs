using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyStatusEffect : BaseStatusEffect 
{

	public EmptyStatusEffect()
	{
		StatusEffectName = "Empty";
		StatusEffectDescription = "Empty status effect.";
		StatusEffectID = 3;
		StatusEffectDamage = 0;
		StatusEffectApplyChance = 0;
		StatusEffectMinTurnApplied = 0;
		StatusEffectMaxTurnApplied = 0;
	}
}
