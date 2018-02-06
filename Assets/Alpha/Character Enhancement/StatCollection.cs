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
}
