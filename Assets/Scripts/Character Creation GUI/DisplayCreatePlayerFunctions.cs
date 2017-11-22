using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCreatePlayerFunctions
{

    private int classSelection;
    private string[] classSelectionNames = new string[] { "Gladhander", "Chief-of-Staff", "Sophist" };

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
        //name
        //gender
        //age
    }

    public void DisplayMainItems()
    {
        GUI.Label(new Rect(Screen.width / 2, 20, 250, 250), "START A NEW CAMPAIGN");
    }
}
