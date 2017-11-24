using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAbility : BaseAbility 
{

	public AttackAbility()
	{
		AbilityName = "Attack";
		AbilityDescription = "A normal attack. However you would like to interpret that.";
		AbilityID = 1;
		AbilityDamage = 4;
		AbilityCost = 0;
		AbilityType = AbilityTypes.ACTIVE;
		AbilityRank = 1;
	}
}
