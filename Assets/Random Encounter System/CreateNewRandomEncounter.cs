using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewRandomEncounter : MonoBehaviour
{

    private BasePlayer newPlayer;
    //private BaseRandomEncounter newEncounter;
    private BaseOpportunity newOpportunity;
    private BaseChallenge newChallenge;


	// Use this for initialization
	void Awake ()
    {
        newPlayer = new BasePlayer();
        newPlayer.PlayerClass = new BaseGladhanderClass();
        newOpportunity = new BaseOpportunity();
        CreateNewEncounter();
	}

    public void CreateNewEncounter()
    {
        ChooseEncounterType();
        CreateNewOpportunity();
    }

    private void ChooseEncounterType()
    {
        //int randomTemp = Random.Range(1, 3);

        //if (randomTemp == 1)
        //{
        //    newEncounter.EncounterType = BaseRandomEncounter.EncounterTypes.OPPORTUNITY;
        //}
        //else
        //{
        //    newEncounter.EncounterType = BaseRandomEncounter.EncounterTypes.CHALLENGE;
        //}
    }

    private void CreateNewOpportunity()
    {
        Skill passiveSkill = new Skill();
        foreach (Skill skill in newPlayer.PlayerClass.CharacterClassSkills)
        {
            if (skill.SkillType == Skill.SkillTypes.PASSIVE)
            {
                passiveSkill = skill;
            }
        }

        newOpportunity.EncounterID = 1;
        newOpportunity.ItemReward = new BaseFood();
        newOpportunity.MoneyReward = Random.Range(1, 11);
        newOpportunity.ExperienceReward = 10;
        //newOpportunity.PassiveSkillToCheck = passiveSkill;
        //Debug.Log("Player's passive skill: " + newOpportunity.PassiveSkillToCheck.SkillName);
        newOpportunity.SkillTarget = 1;
        newOpportunity.OpportunityDescription = "A well-dressed young woman approaches you. She claims to be a representative of a nonprofit interested in backing your campaign. " +
            "Instead of offering scathing remarks about your political views on the sustainability of the rainforests, she invites you to join her and her peers at their headquarters in the Financial District.";
        newOpportunity.OpportunitySuccessDescription = "You follow the woman to her office building, whereupon you show them the glory of the new world order you wish to establish " +
            "when you finally get elected. They are incredibly impressed with the content of your character, and immediately donate a sizable sum to your campaign.";
        newOpportunity.InspectText = "See what these plebeians have to say.";
        newOpportunity.InspectDescription = "As you listen to the presentation the woman and her peers have arranged for you, you simply nod absently. After two hours, your patience is finally rewarded.";
    }

    void OnGUI()
    {
        GUILayout.Label(newOpportunity.OpportunityDescription);

        if (GUILayout.Button(newOpportunity.InspectText))
        {
            Debug.Log("Inspected");
            Debug.Log(newOpportunity.InspectDescription);
            newOpportunity.Complete();
            Debug.Log(newOpportunity.IsComplete);
            newOpportunity.Reward();
        }
//        if (GUILayout.Button(newOpportunity.PassiveSkillToCheck.SkillName + " (" + newOpportunity.SkillTarget + ")"))
        {
            newOpportunity.CheckSkill();
            Debug.Log("Skill checked");
            Debug.Log(newOpportunity.OpportunitySuccessDescription);
            newOpportunity.Complete();
            newOpportunity.Reward();
        }
    }
}
