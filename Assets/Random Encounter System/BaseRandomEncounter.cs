using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRandomEncounter
{

    private int encounterID;
    private int experienceReward;
    private int moneyReward;
    private BaseItem itemReward;
    private Skill passiveSkillToCheck;
    private int skillTarget;
    private bool passedSkillCheck = false;
    private bool isComplete = false;

    public enum EncounterTypes
    {
        CHALLENGE,
        OPPORTUNITY
    }

    private EncounterTypes encounterType;

    public int EncounterID { get; set; }
    public EncounterTypes EncounterType { get; set; }
    public int ExperienceReward { get; set; }
    public int MoneyReward { get; set; }
    public BaseItem ItemReward { get; set; }
    public int SkillTarget { get; set; }
    public Skill PassiveSkillToCheck { get; set; }
    public bool PassedSkillCheck { get; set; }
    public bool IsComplete { get; set; }

    public void CheckSkill()
    {
        if (PassiveSkillToCheck.SkillRank >= skillTarget)
        {
            PassedSkillCheck = true;
        }
        else
        {
            PassedSkillCheck = false;
        }
    }

    public void Complete()
    {
        IsComplete = true;
    }
}
