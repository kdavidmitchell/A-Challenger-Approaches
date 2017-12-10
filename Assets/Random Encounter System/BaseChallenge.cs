using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseChallenge : BaseRandomEncounter 
{

	private string challengeDescription;
    private string challengeSuccessDescription;

    public string ChallengeDescription { get; set; }
    public string ChallengeSuccessDescription { get; set; }

    public BaseChallenge()
    {
    	EncounterID = 1;
    	ItemReward = new BaseWeapon();
        MoneyReward = Random.Range(1, 11);
        ExperienceReward = 10;
        PassiveSkillToCheck = GameInformation.PassiveAbility;
        Debug.Log("Player's passive skill: " + PassiveSkillToCheck.AbilityName);
        SkillTarget = 1;
        ChallengeDescription = "A disgruntled looking man in a dirty suit swaggers in your direction, shouting something about cryptocurrency. " +
            "He swivels his unsettling gaze on you, and before you know it, he has his arms on your shoulders. You can smell the liquor on his breath.";
        ChallengeSuccessDescription = "You quickly make short work of the man's lesser opinions, and, defeated, he shrugs and begins to terrorize someone else on the street.";
    }

    public void Reward()
    {
        if (PassedSkillCheck)
        {
            Debug.Log(PassedSkillCheck);
            //give player exp
            Debug.Log("Player passed skill check! Awarded " + ExperienceReward + " XP!");
        }
        if (IsComplete)
        {
            Debug.Log(IsComplete);
            //give item
            Debug.Log("Player completed encounter! Awarded " + ItemReward.ItemName + " and " + MoneyReward + " dollars!");
        }
        //close encounter
    }
}
