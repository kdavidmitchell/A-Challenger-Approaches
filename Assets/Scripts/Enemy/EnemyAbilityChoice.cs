using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAbilityChoice 
{

	private BaseAbility chosenAbility;

	public BaseAbility ChooseEnemyAbility()
	{
		return chosenAbility = new AttackAbility();
	}
}
