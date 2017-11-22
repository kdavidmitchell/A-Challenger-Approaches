using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatAllocationModule
{

    private string[] statNames = new string[3] { "Rhetoric", "Image", "Diplomacy" };
    private string[] statDescriptions = new string[3] { "The persuasive power of all politicians.", "The measure by which all politicians are judged.", "The backbone of all politicians." };
    private bool[] statSelections = new bool[3];

    private int[] pointsToAllocate = new int[3]; //starting stat values for the chosen class, 
    private int[] baseStatPoints = new int[3]; //starting stat values for the chosen class

    public void DisplayStatAllocationModule()
    {
        RetrieveBaseStatPoints();
        DisplayToggleSwitches();
        DisplayStatIncreaseDecreaseButtons();
    }

    private void DisplayToggleSwitches()
    {
        for (int i = 0; i < statNames.Length; i++)
        {
            statSelections[i] = GUI.Toggle(new Rect(10, 60 * i + 10, 100, 50), statSelections[i], statNames[i]);


            //GUI.Label


            if (statSelections[i])
            {
                GUI.Label(new Rect(20, 60 * i + 30, 150, 100), statDescriptions[i]);
            }
        }
    }

    private void DisplayStatIncreaseDecreaseButtons()
    {
        for (int i = 0; i < pointsToAllocate.Length; i++)
        {
            if(GUI.Button(new Rect(200, 60 * i + 10, 50, 50), "+"))
            {

            }
            if(GUI.Button(new Rect(260, 60 * i + 10, 50, 50), "-"))
            {

            }
        }
    }

    private void RetrieveBaseStatPoints()
    {
        BaseCharacterClass characterClass = new BaseSophistClass();

        pointsToAllocate[0] = characterClass.Rhetoric;
        baseStatPoints[0] = characterClass.Rhetoric;

        pointsToAllocate[1] = characterClass.Image;
        baseStatPoints[1] = characterClass.Image;

        pointsToAllocate[2] = characterClass.Diplomacy;
        baseStatPoints[2] = characterClass.Diplomacy;
    }
}
