using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatCollection
{

	private Dictionary<StatType, Stat> _statDict;

	public StatCollection()
	{
		_statDict = new Dictionary<StatType, Stat>();
		ConfigureStats();
	}

	protected virtual void ConfigureStats()
	{
		
	}

	public bool Contains(StatType statType)
	{
		return _statDict.ContainsKey(statType);
	}

	public Stat GetStat(StatType statType)
	{
		if (Contains(statType))
		{
			return _statDict[statType];
		}

		return null;
	}

	protected Stat CreateStat(StatType statType)
	{
		Stat stat = new Stat();
		_statDict.Add(statType, stat);
		return stat;
	}

	protected Stat CreateOrGetStat(StatType statType)
	{
		Stat stat = GetStat(statType);
		if (stat == null)
		{
			stat = CreateStat(statType);
		}

		return stat;
	}
}
