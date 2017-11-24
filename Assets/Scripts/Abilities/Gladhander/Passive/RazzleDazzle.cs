using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RazzleDazzle : BaseAbility 
{

	public RazzleDazzle()
	{
		AbilityName = "The Ol' Razzle Dazzle";
		AbilityDescription = "With a flashy smile, you can get out of the stickiest of situations.";
		AbilityID = 5;
		AbilityDamage = 0;
		AbilityCost = 0;
		AbilityType = AbilityTypes.PASSIVE;
		AbilityRank = 1;
	}
}
