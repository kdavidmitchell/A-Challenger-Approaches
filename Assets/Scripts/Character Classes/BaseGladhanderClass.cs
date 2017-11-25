using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGladhanderClass: BaseCharacterClass
{
    private Skill combatSkill = new Skill();
    private Skill passiveSkill = new Skill();

    public BaseGladhanderClass()
    {
        CharacterClassName = "Gladhander";
        CharacterClassDescription = "You are a well of infinite charm. A good smile, a strong chin, and a head of neatly coifed hair: " +
            "these are the tools of the gladhander. Make friends out of enemies, summon your most " +
            "devout constituents to aid you, and flash those pearly whites.";

        Rhetoric = 7;
        Diplomacy = 8;
        Image = 9;
		CharacterClass = CharacterClasses.GLADHANDER;
		playerAbilities.Add (new AttackAbility ());
		playerAbilities.Add (new ToMyAide ());
		playerAbilities.Add (new RazzleDazzle ());

        combatSkill.SkillName = "To My Aide!";
        combatSkill.SkillDescription = "Summons an underpaid, overworked intern to harass your enemies with requests for overdue paperwork.";
        combatSkill.SkillID = 1;
        combatSkill.SkillRank = 1;
        combatSkill.SkillType = Skill.SkillTypes.COMBAT;
        combatSkill.ExperienceNeededToLevelSkill = 10;

        passiveSkill.SkillName = "The Ol' Razzle-Dazzle";
        passiveSkill.SkillDescription = "With a flashy smile, you can get out of the stickiest of situations.";
        passiveSkill.SkillID = 2;
        passiveSkill.SkillRank = 1;
        passiveSkill.SkillType = Skill.SkillTypes.PASSIVE;
        passiveSkill.ExperienceNeededToLevelSkill = 10;

        CharacterClassSkills = new List<Skill> { combatSkill, passiveSkill };

    }
}
