using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCreatePlayerFunctions
{

    private int classSelection;
    private string[] classSelectionNames = new string[] { "Gladhander", "Chief-of-Staff", "Sophist" };

	private string playerFirstName = "Enter first name.";
	private string playerLastName = "Enter last name."; //name of player character
	private string playerBio = "Enter your politician's bio.";
	private bool isMale = true; //gender selection

	private int genderSelection;
	private string[] genderTypes = new string[2] { "Male", "Female" };

    private StatAllocationModule statAllocationModule = new StatAllocationModule();

	public void DisplayClassSelections()
    {
        //list of toggle buttons and each button will be a different class
        //selection grid
        classSelection = GUI.SelectionGrid(new Rect(50,50,250,300), classSelection, classSelectionNames, 1);
        GUI.Label(new Rect(450, 50, 300, 300), FindClassDescription(classSelection));
        GUI.Label(new Rect(450, 175, 300, 300), FindClassStatValues(classSelection));
    }

    private string FindClassDescription(int classSelection)
    {
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseGladhanderClass();
            return tempClass.CharacterClassDescription;
        } else if (classSelection == 1)
        {
            BaseCharacterClass tempClass = new BaseChiefClass();
            return tempClass.CharacterClassDescription;
        } else
        {
            BaseCharacterClass tempClass = new BaseSophistClass();
            return tempClass.CharacterClassDescription;
        }
    }

    private string FindClassStatValues(int classSelection)
    {
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseGladhanderClass();
            string tempStats = "Rhetoric: " + tempClass.Rhetoric + "\n" +
                                "Image: " + tempClass.Image + "\n" +
                                "Diplomacy: " + tempClass.Diplomacy;
            return tempStats;
        }
        else if (classSelection == 1)
        {
            BaseCharacterClass tempClass = new BaseChiefClass();
            string tempStats = "Rhetoric: " + tempClass.Rhetoric + "\n" +
                                "Image: " + tempClass.Image + "\n" +
                                "Diplomacy: " + tempClass.Diplomacy;
            return tempStats;
        }
        else
        {
            BaseCharacterClass tempClass = new BaseSophistClass();
            string tempStats = "Rhetoric: " + tempClass.Rhetoric + "\n" +
                                "Image: " + tempClass.Image + "\n" +
                                "Diplomacy: " + tempClass.Diplomacy;
            return tempStats;
        }
    }

    public void DisplayStatAllocation()
    {
        statAllocationModule.DisplayStatAllocationModule();
    }

    public void DisplayFinalSetup()
    {
        //name and bio
		playerFirstName = GUI.TextArea(new Rect(20, 10, 150, 25), playerFirstName, 25);
		playerLastName = GUI.TextArea (new Rect (20, 55, 150, 25), playerLastName, 25);
		playerBio = GUI.TextArea (new Rect (20, 100, 250, 200), playerBio, 250);
        
		//gender
		genderSelection = GUI.SelectionGrid(new Rect(200, 10, 100, 80), genderSelection, genderTypes, 1);

        //age
    }

	private void ChooseClass(int classSelection)
	{
		if (classSelection == 0) {
			GameInformation.PlayerClass = new BaseGladhanderClass ();
		} else if (classSelection == 1) {
			GameInformation.PlayerClass = new BaseChiefClass ();
		} else 
		{
			GameInformation.PlayerClass = new BaseSophistClass ();
		}
	}

    public void DisplayMainItems()
    {
        GUI.Label(new Rect(Screen.width / 2, 20, 250, 250), "START A NEW CAMPAIGN");

		if (CreatePlayerGUI.currentState != CreatePlayerGUI.CreatePlayerStates.FINAL_SETUP) 
		{
			if (GUI.Button (new Rect (470, 370, 50, 50), "Next")) 
			{
				if (CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.CLASS_SELECTION) 
				{
					ChooseClass (classSelection);
					CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.STAT_ALLOCATION;
				} else if (CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.STAT_ALLOCATION) 
				{
					GameInformation.Rhetoric = statAllocationModule.pointsToAllocate [0];
					GameInformation.Image = statAllocationModule.pointsToAllocate [1];
					GameInformation.Diplomacy = statAllocationModule.pointsToAllocate [2];

					CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.FINAL_SETUP;
				}
			}
		} else if (CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.FINAL_SETUP) 
		{
			if (GUI.Button (new Rect (525, 370, 50, 50), "Finish")) 
			{
				GameInformation.PlayerName = playerFirstName + " " + playerLastName;
				GameInformation.PlayerBio = playerBio;
				if (genderSelection == 0) {
					GameInformation.IsMale = true;
				} else if (genderSelection == 1) 
				{
					GameInformation.IsMale = false;
				}
				SaveInformation.SaveAllInformation();
			}
		}

		if (CreatePlayerGUI.currentState != CreatePlayerGUI.CreatePlayerStates.CLASS_SELECTION) 
		{
			if (GUI.Button (new Rect (295, 370, 50, 50), "Back")) 
			{
				if (CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.STAT_ALLOCATION) 
				{
					statAllocationModule.ranOnce = false;
					GameInformation.PlayerClass = null;
					CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.CLASS_SELECTION;
				} else if (CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.FINAL_SETUP) 
				{
					CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.STAT_ALLOCATION;
				}
			}
		}
    }
}
