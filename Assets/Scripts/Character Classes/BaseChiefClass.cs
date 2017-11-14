using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseChiefClass : BaseCharacterClass
{
    private Skill combatSkill = new Skill();
    private Skill passiveSkill = new Skill();

    public BaseChiefClass()
    {
        CharacterClassName = "Chief-of-Staff";
        CharacterClassDescription = "You have no need to speak softly, because you have the biggest stick around. " +
            "Militarily minded and calculatingly cold, you, and you alone, have the strength to do what needs to be done. " +
            "Shout at your enemies until they fall into a daze, guard yourself with an army of aides, and show that diplomacy " +
            "really just means 'force'.";

        Rhetoric = 8;
        Diplomacy = 9;
        Image = 7;

        combatSkill.SkillName = "The Big Stick of Diplomacy";
        combatSkill.SkillDescription = "You brandish your weapon of choice menacingly and swing it upside the head of your enemy with incredible diplomatic skill.";
        combatSkill.SkillID = 3;
        combatSkill.SkillRank = 1;
        combatSkill.SkillType = Skill.SkillTypes.COMBAT;
        combatSkill.ExperienceNeededToLevelSkill = 10;

        passiveSkill.SkillName = "Glower of Hate";
        passiveSkill.SkillDescription = "Your eyes alone are enough to make your foes quake in fear.";
        passiveSkill.SkillID = 4;
        passiveSkill.SkillRank = 1;
        passiveSkill.SkillType = Skill.SkillTypes.PASSIVE;
        passiveSkill.ExperienceNeededToLevelSkill = 10;

        CharacterClassSkills = new List<Skill> { combatSkill, passiveSkill };
    }	
}
