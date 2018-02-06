using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat 
{

	private string _statName;
	private int _statValue;

	public string StatName
	{
		get { return _statName; }
		set { _statName = value; }
	}

	public int StatValue
	{
		get { return _statValue; }
		set { _statValue = value; }
	}

	public Stat()
	{
		this.StatName = string.Empty;
		this.StatValue = 0;
	}

	public Stat(string name, int value)
	{
		this.StatName = name;
		this.StatValue = value;
	}
}
