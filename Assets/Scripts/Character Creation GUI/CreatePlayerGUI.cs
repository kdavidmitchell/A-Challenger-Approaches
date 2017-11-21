using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayerGUI : MonoBehaviour {

    public enum CreatePlayerStates
    {
        CLASS_SELECTION, //display all class types
        FINAL_SETUP //add name, select gender, and misc items
    }

    private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions();
    public static CreatePlayerStates currentState;

	// Use this for initialization
	void Start ()
    {
        currentState = CreatePlayerStates.CLASS_SELECTION;	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    switch (currentState)
        {
            case (CreatePlayerStates.CLASS_SELECTION):
                break;
            case (CreatePlayerStates.FINAL_SETUP):
                break;
        }	
	}

    void OnGUI()
    {
        displayFunctions.DisplayMainItems();
        if (currentState == CreatePlayerStates.CLASS_SELECTION)
        {
            //display class selection function
            displayFunctions.DisplayClassSelections();
        }
        if (currentState == CreatePlayerStates.FINAL_SETUP)
        {
            //display final setup functions
            displayFunctions.DisplayFinalSetup();
        }
    }
}
