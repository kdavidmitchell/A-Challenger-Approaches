using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatCalculations 
{

	private float enemyRhetoricModifier = 0.2f;
	private float enemyImageModifier = 0.2f;
	private float enemyDiplomacyModifier = 0.2f;
	private float playerDiplomacyModifier = 0.3f;
	private float playerRhetoricModifier = 0.3f;
	private float modifier;

	private float mainStatModifier = 0.5f;

	public enum StatType
	{
		RHETORIC,
		IMAGE,
		DIPLOMACY
	}

	public int CalculateStat(int statVal, StatType statType, int level, bool isEnemy)
	{
		if (isEnemy) {
			SetEnemyModifier (statType);
			return (statVal + (int)((statVal * modifier) * level));
		} else
		{
			SetPlayerModifier (statType);
			return (statVal + (int)((statVal * modifier) * level));
		}
			
	}

	private void SetEnemyModifier(StatType statType)
	{
		if (statType == StatType.RHETORIC) 
		{
			modifier = enemyRhetoricModifier;
		}

		if (statType == StatType.IMAGE) 
		{
			modifier = enemyImageModifier;
		}

		if (statType == StatType.DIPLOMACY) 
		{
			modifier = enemyDiplomacyModifier;
		}
	}

	private void SetPlayerModifier(StatType statType)
	{
		if (statType == StatType.RHETORIC) 
		{
			modifier = playerRhetoricModifier;
		}

		if (statType == StatType.DIPLOMACY) 
		{
			modifier = playerDiplomacyModifier;
		}
	}

	public int CalculateHealth(int statVal)
	{
		return statVal * 10; //calculate health based on total diplomacy stat times 10
	}

	public int CalculateEnergy(int statVal)
	{
		return statVal * 5; //calculate energy based on total rhetoric stat times 5
	}

	public int FindPlayerMainStatAndCalculateMainStatModifier()
	{
		if (GameInformation.PlayerClass.CharacterClassName == "Gladhander") 
		{
			return (int)(GameInformation.Image * mainStatModifier);
		}
		if (GameInformation.PlayerClass.CharacterClassName == "Chief-of-Staff") 
		{
			return (int)(GameInformation.Diplomacy * mainStatModifier);
		}
		if (GameInformation.PlayerClass.CharacterClassName == "Sophist") 
		{
			return (int)(GameInformation.Rhetoric * mainStatModifier);
		}

		return 1;
	}
}
