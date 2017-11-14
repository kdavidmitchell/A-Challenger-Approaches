using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseOpportunity : BaseRandomEncounter
{
    private string opportunityDescription;
    private string inspectText;
    private string inspectDescription;
    private string opportunitySuccessDescription;

    public string OpportunityDescription { get; set; }
    public string InspectText { get; set; }
    public string InspectDescription { get; set; }
    public string OpportunitySuccessDescription { get; set; }

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
