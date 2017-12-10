using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseChallenge : BaseRandomEncounter 
{

	private string challengeDescription;
    private string challengeSuccessDescription;

    public string ChallengeDescription { get; set; }
    public string ChallengeSuccessDescription { get; set; }

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
