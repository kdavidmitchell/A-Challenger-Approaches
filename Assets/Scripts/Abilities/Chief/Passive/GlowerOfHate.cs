using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowerOfHate : BaseAbility 
{

	public GlowerOfHate()
	{
		AbilityName = "The Glower of Hate";
		AbilityDescription = "Your eyes alone are enough to make your foes quake in fear.";
		AbilityID = 3;
		AbilityDamage = 0;
		AbilityCost = 0;
		AbilityType = AbilityTypes.PASSIVE;
		AbilityRank = 1;
	}
}
