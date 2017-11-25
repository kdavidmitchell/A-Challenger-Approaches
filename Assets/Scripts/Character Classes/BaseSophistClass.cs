using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSophistClass : BaseCharacterClass
{

    private Skill combatSkill = new Skill();
    private Skill passiveSkill = new Skill();

    public BaseSophistClass()
    {
        CharacterClassName = "Sophist";
        CharacterClassDescription = "You've always known that the pen is mightier than the sword. " +
            "In vocal power and eloquence, you have no equal. Bore your enemies to death with long " +
            "speeches, lull them to sleep with the rich cadence of your voice, or outsmart their every move.";

        Rhetoric = 9;
        Diplomacy = 7;
        Image = 8;
		CharacterClass = CharacterClasses.SOPHIST;
		playerAbilities.Add (new AttackAbility ());
		playerAbilities.Add (new Tirade ());
		playerAbilities.Add (new QuestionableLogic ());

        combatSkill.SkillName = "Long-winded Tirade";
        combatSkill.SkillDescription = "Your skill in filibustering is legend, and almost all of your speeches have been known to put your foes into a deep sleep.";
        combatSkill.SkillID = 5;
        combatSkill.SkillRank = 1;
        combatSkill.SkillType = Skill.SkillTypes.COMBAT;
        combatSkill.ExperienceNeededToLevelSkill = 10;

        passiveSkill.SkillName = "Questionable Logic";
        passiveSkill.SkillDescription = "Within a single conversation, you can convince someone that a rectangle has actually been a square this whole time.";
        passiveSkill.SkillID = 6;
        passiveSkill.SkillRank = 1;
        passiveSkill.SkillType = Skill.SkillTypes.PASSIVE;
        passiveSkill.ExperienceNeededToLevelSkill = 10;

        CharacterClassSkills = new List<Skill> { combatSkill, passiveSkill };
    }
	
}
