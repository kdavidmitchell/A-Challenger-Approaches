using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer
{

    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int rhetoric;
    private int image;
    private int diplomacy;
    private List<Skill> playerSkills;

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

    public BaseCharacterClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
    }

    public int Image
    {
        get { return image; }
        set { image = value; }
    }

    public int Rhetoric
    {
        get { return rhetoric; }
        set { rhetoric = value; }
    }

    public int Diplomacy
    {
        get { return diplomacy; }
        set { diplomacy = value; }
    }

    public List<Skill> PlayerSkills
    {
        get { return playerSkills; }
        set { playerSkills = value; }
    }

}
