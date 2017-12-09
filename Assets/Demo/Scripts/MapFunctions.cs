﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapFunctions : MonoBehaviour 
{

	public Image player;
	public GameObject footprints;
	
	public Image randomOpportunity;
	public Text opportunityTitle;
	public Text opportunityDescription;
	public Image opportunityInspectButton;
	public Text opportunityInspectText;
	public Image opportunitySkillCheckButton;
	public Text opportunitySkillCheckText;

	public Image randomChallenge;
	public Text challengeTitle;
	public Text challengeDescription;
	public Image challengeFightButton;
	public Text challengeFightText;
	public Image challengeSkillCheckButton;
	public Text challengeSkillCheckText;

	//Opportunity information
	private BaseOpportunity tempOpportunity = new BaseOpportunity();


	// Use this for initialization
	void Start () 
	{
		DisablePopups();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	private void DisablePopups()
	{
		randomOpportunity.enabled = false;
		opportunityTitle.enabled = false;
		opportunityDescription.enabled = false;
		opportunityInspectButton.enabled = false;
		opportunityInspectText.enabled = false;
		opportunitySkillCheckButton.enabled = false;
		opportunitySkillCheckText.enabled = false;

		randomChallenge.enabled = false;
		challengeTitle.enabled = false;
		challengeDescription.enabled = false;
		challengeFightButton.enabled = false;
		challengeFightText.enabled = false;
		challengeSkillCheckButton.enabled = false;
		challengeSkillCheckText.enabled = false;
	}

	private void EnableOpportunity()
	{
		randomOpportunity.enabled = true;
		opportunityTitle.enabled = true;
		opportunityDescription.enabled = true;
		opportunityInspectButton.enabled = true;
		opportunityInspectText.enabled = true;
		opportunitySkillCheckButton.enabled = true;
		opportunitySkillCheckText.enabled = true;
	}

	private void EnableChallenge()
	{
		randomChallenge.enabled = true;
		challengeTitle.enabled = true;
		challengeDescription.enabled = true;
		challengeFightButton.enabled = true;
		challengeFightText.enabled = true;
		challengeSkillCheckButton.enabled = true;
		challengeSkillCheckText.enabled = true;
	}

	private void DisableOpportunityButtons()
	{
		opportunityInspectButton.enabled = false;
		opportunityInspectText.enabled = false;
		opportunitySkillCheckButton.enabled = false;
		opportunitySkillCheckText.enabled = false;
	}

	public void InvokeWander()
	{
		Instantiate(footprints, player.transform.position, Quaternion.identity);
		Invoke("Wander", 3f);
	}

	public void Wander()
	{
		CreateNewRandomEncounter();
	}

	public void CreateNewRandomEncounter()
	{
		if (Random.value < 0.5f)
		{
			tempOpportunity.EncounterID = 1;
        	tempOpportunity.ItemReward = new BaseFood();
	        tempOpportunity.MoneyReward = Random.Range(1, 11);
	        tempOpportunity.ExperienceReward = 10;
	        tempOpportunity.PassiveSkillToCheck = GameInformation.PassiveAbility;
	        Debug.Log("Player's passive skill: " + tempOpportunity.PassiveSkillToCheck.AbilityName);
	        tempOpportunity.SkillTarget = 1;
	        tempOpportunity.OpportunityDescription = "A well-dressed young woman approaches you. She claims to be a representative of a nonprofit interested in backing your campaign. " +
	            "Instead of offering scathing remarks about your political views on the sustainability of the rainforests, she invites you to join her and her peers at their headquarters in the Financial District.";
	        tempOpportunity.OpportunitySuccessDescription = "You follow the woman to her office building, whereupon you show them the glory of the new world order you wish to establish " +
	            "when you finally get elected. They are incredibly impressed with the content of your character, and immediately donate a sizable sum to your campaign.";
	        tempOpportunity.InspectText = "See what these plebeians have to say.";
	        tempOpportunity.InspectDescription = "As you listen to the presentation the woman and her peers have arranged for you, you simply nod absently. After two hours, your patience is finally rewarded.";

	        opportunityDescription.text = tempOpportunity.OpportunityDescription;
	        opportunityInspectText.text = tempOpportunity.InspectText;
	        opportunitySkillCheckText.text = tempOpportunity.PassiveSkillToCheck.AbilityName + " (" + tempOpportunity.SkillTarget + ")";

	        EnableOpportunity();
		}
	}

	public void CompleteOpportunityAndRewardNoSkillCheck()
	{
		DisableOpportunityButtons();

		tempOpportunity.Complete();
		tempOpportunity.Reward();

		opportunityDescription.text = tempOpportunity.InspectDescription + "\n\nYou are awarded " + tempOpportunity.ItemReward.ItemName + " and " + tempOpportunity.MoneyReward + " dollars!";

		Invoke("DisablePopups", 8f);
	}

	public void CompleteOpportunityAndReward()
	{
		DisableOpportunityButtons();

		tempOpportunity.CheckSkill();
		tempOpportunity.Complete();
		tempOpportunity.Reward();

		opportunityDescription.text = tempOpportunity.OpportunitySuccessDescription + "\n\nYou are awarded " + tempOpportunity.ExperienceReward + " XP, " + tempOpportunity.ItemReward.ItemName + ", and " + tempOpportunity.MoneyReward + " dollars!";

		Invoke("DisablePopups", 8f);
	}
}
