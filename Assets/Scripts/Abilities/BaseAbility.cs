using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseAbility 
{

	private string abilityName;
	private string abilityDescription;
	private int abilityID;
	private int abilityDamage;
	private int abilityCost;
	private AbilityTypes abilityType;
	private int abilityRank;
	private BaseStatusEffect abilityStatusEffect;

	public enum AbilityTypes
	{
		ACTIVE,
		PASSIVE
	}

	public string AbilityName
	{
		get { return abilityName; }
		set { abilityName = value; }
	}

	public string AbilityDescription
	{
		get { return abilityDescription; }
		set { abilityDescription = value; }
	}

	public int AbilityID
	{
		get { return abilityID; }
		set { abilityID = value; }
	}

	public int AbilityDamage
	{
		get { return abilityDamage; }
		set { abilityDamage = value; }
	}

	public int AbilityCost
	{
		get { return abilityCost; }
		set { abilityCost = value; }
	}

	public AbilityTypes AbilityType
	{
		get { return abilityType; }
		set { abilityType = value; }
	}

	public int AbilityRank
	{
		get { return abilityRank; }
		set { abilityRank = value; }
	}

	public BaseStatusEffect AbilityStatusEffect
	{
		get { return abilityStatusEffect; }
		set { abilityStatusEffect = value; }
	}
}
