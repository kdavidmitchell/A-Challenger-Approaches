using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionableLogic : BaseAbility 
{

	public QuestionableLogic()
	{
		AbilityName = "Questionable Logic";
		AbilityDescription = "Within a single conversation, you can convince someone that a rectangle has actually been a square this whole time.";
		AbilityID = 7;
		AbilityDamage = 0;
		AbilityCost = 0;
		AbilityType = AbilityTypes.PASSIVE;
		AbilityRank = 1;
	}
}
