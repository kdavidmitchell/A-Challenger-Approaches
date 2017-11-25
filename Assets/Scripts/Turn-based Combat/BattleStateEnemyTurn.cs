using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateEnemyTurn 
{

	private EnemyAbilityChoice enemyAbilityChoiceScript = new EnemyAbilityChoice();

	public void EnemyTakeTurn()
	{
		//choose an ability
		TurnBasedCombatStateMachine.enemyUsedAbility = enemyAbilityChoiceScript.ChooseEnemyAbility();
		//calculate damage
		TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATE_DAMAGE;
		//end turn
	}
}
