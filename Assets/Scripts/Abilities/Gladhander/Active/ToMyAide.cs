using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMyAide : BaseAbility 
{

	public ToMyAide()
	{
		AbilityName = "To My Aide!";
		AbilityDescription = "Summons an underpaid, overworked intern to harass your enemies with requests for overdue paperwork.";
		AbilityID = 4;
		AbilityDamage = 3;
		AbilityCost = 2;
		AbilityType = AbilityTypes.ACTIVE;
		AbilityRank = 1;
	}
}
