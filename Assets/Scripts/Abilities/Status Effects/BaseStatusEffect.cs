using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseStatusEffect 
{

	private string statusEffectName;
	private string statusEffectDescription;
	private int statusEffectID;
	private int statusEffectDamage;
	private int statusEffectApplyChance;
	private int statusEffectMinTurnApplied;
	private int statusEffectMaxTurnApplied;

	public string StatusEffectName
	{
		get { return statusEffectName; }
		set { statusEffectName = value; }
	}

	public string StatusEffectDescription
	{
		get { return statusEffectDescription; }
		set { statusEffectDescription = value; }
	}

	public int StatusEffectID
	{
		get { return statusEffectID; }
		set { statusEffectID = value; }
	}

	public int StatusEffectDamage
	{
		get { return statusEffectDamage; }
		set { statusEffectDamage = value; }
	}

	public int StatusEffectApplyChance
	{
		get { return statusEffectApplyChance; }
		set { statusEffectApplyChance = value; }
	}

	public int StatusEffectMinTurnApplied
	{
		get { return statusEffectMinTurnApplied; }
		set { statusEffectMinTurnApplied = value; }
	}

	public int StatusEffectMaxTurnApplied
	{
		get { return statusEffectMaxTurnApplied; }
		set { statusEffectMaxTurnApplied = value; }
	}


}
