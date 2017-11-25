using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAbilityChoice 
{

	private int totalPlayerHealth;
	private int playerHealthPercentage;

	private BaseAbility chosenAbility;

	public BaseAbility ChooseEnemyAbility()
	{
		return chosenAbility = new AttackAbility();
	}
}
