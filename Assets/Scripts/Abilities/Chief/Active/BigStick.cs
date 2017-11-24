using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigStick : BaseAbility 
{

	public BigStick()
	{
		AbilityName = "The Big Stick of Diplomacy";
		AbilityDescription = "You brandish your weapon of choice menacingly and bash your opponent, stunning them for 1 turn.";
		AbilityID = 2;
		AbilityDamage = 2;
		AbilityCost = 1;
		AbilityType = AbilityTypes.ACTIVE;
		AbilityRank = 1;
	}

}
