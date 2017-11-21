using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Skill
{

    private string skillName;
    private string skillDescription;
    private int skillRank;
    private int skillID;
    private int experienceNeededToLevelSkill;

    public enum SkillTypes
    {
        COMBAT,
        PASSIVE
    }

    private SkillTypes skillType;

    public string SkillName { get; set; }
    public string SkillDescription { get; set; }
    public int SkillRank { get; set; }
    public int SkillID { get; set; }
    public SkillTypes SkillType { get; set; }
    public int ExperienceNeededToLevelSkill { get; set; }
}
