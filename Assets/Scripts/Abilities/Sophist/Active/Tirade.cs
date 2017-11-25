using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirade : BaseAbility
{

	public Tirade()
	{
		AbilityName = "Long-Winded Tirade";
		AbilityDescription = "Your skill in filibustering is legend, and almost all of your speeches have been known to put your foes into a deep sleep.";
		AbilityID = 6;
		AbilityDamage = 2;
		AbilityCost = 2;
		AbilityType = AbilityTypes.ACTIVE;
		AbilityRank = 1;
		AbilityStatusEffect = new SleepStatusEffect ();
	}
}
