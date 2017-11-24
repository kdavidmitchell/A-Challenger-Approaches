using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass
{

    private string characterClassName;
    private string characterClassDescription;
	private CharacterClasses characterClass;

    //Statistics
    private int diplomacy;
    private int rhetoric;
    private int image;

	public enum CharacterClasses
	{
		GLADHANDER,
		CHIEF,
		SOPHIST
	}

    //Skills
    private List<Skill> characterClassSkills;

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

    public int Diplomacy
    {
        get { return diplomacy; }
        set { diplomacy = value; }
    }

    public int Rhetoric
    {
        get { return rhetoric; }
        set { rhetoric = value; }
    }

    public int Image
    {
        get { return image; }
        set { image = value; }
    }

	public CharacterClasses CharacterClass
	{
		get { return characterClass; }
		set { characterClass = value; }
	}

    public List<Skill> CharacterClassSkills
    {
        get { return characterClassSkills; }
        set { characterClassSkills = value; }
    }
}
