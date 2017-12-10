using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CCFunctions : MonoBehaviour 
{

	private string[] classNames = new string[] { "Gladhander", "Chief-of-Staff", "Sophist" };
	private string[] classDescriptions = new string[3];
	private int[] gladhanderStats = new int[3];
	private int[] chiefStats = new int[3];
	private int[] sophistStats = new int[3];

	private BaseCharacterClass tempGladhander = new BaseGladhanderClass();
	private BaseCharacterClass tempChief = new BaseChiefClass();
	private BaseCharacterClass tempSophist = new BaseSophistClass();

	private Toggle class1toggle;
	private Toggle class2toggle;
	private Toggle class3toggle;

	private InputField inputField;

	// Use this for initialization
	void Start () 
	{
		GetClassDescriptions();
		GetClassStats();
		DisplayClassInformation();

		class1toggle = GameObject.Find("Class1Toggle").GetComponent<Toggle>();
		class2toggle = GameObject.Find("Class2Toggle").GetComponent<Toggle>();
		class3toggle = GameObject.Find("Class3Toggle").GetComponent<Toggle>();

		inputField = GameObject.Find("NameField").GetComponent<InputField>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	private void GetClassDescriptions()
	{
		for (int i = 0; i < classDescriptions.Length; i++) 
		{
			if (i == 0)
			{
				classDescriptions[i] = tempGladhander.CharacterClassDescription;
			}
			else if (i == 1)
			{
				classDescriptions[i] = tempChief.CharacterClassDescription;
			}
			else
			{
				classDescriptions[i] = tempSophist.CharacterClassDescription;
			}
		}
	}

	private void GetClassStats()
	{
		for (int i = 0; i < classNames.Length; i++) 
		{
			for (int j = 0; j < gladhanderStats.Length; j++)
			{
				if (i == 0 && j == 0)
				{
					gladhanderStats[j] = tempGladhander.Rhetoric;
				}
				else if (i == 0 && j == 1)
				{
					gladhanderStats[j] = tempGladhander.Image;
				}
				else if (i == 0 && j == 2)
				{
					gladhanderStats[j] = tempGladhander.Diplomacy;
				}
				if (i == 1 && j == 0)
				{
					chiefStats[j] = tempChief.Rhetoric;
				}
				else if (i == 1 && j == 1)
				{
					chiefStats[j] = tempChief.Image;
				}
				else if (i == 1 && j == 2)
				{
					chiefStats[j] = tempChief.Diplomacy;
				}
				if (i == 2 && j == 0)
				{
					sophistStats[j] = tempSophist.Rhetoric;
				}
				else if (i == 2 && j == 1)
				{
					sophistStats[j] = tempSophist.Image;
				}
				else if (i == 2 && j == 2)
				{
					sophistStats[j] = tempSophist.Diplomacy;
				}
			}
		}
	}

	private void DisplayClassInformation()
	{
		Text tempText;
		string tempString;
		int tempInt;
		
		for (int i = 0; i < classNames.Length; i++) 
		{
			tempText = GameObject.Find("Class" + (i + 1) + "Name").GetComponent<Text>();
			tempString = classNames[i];
			tempText.text = tempString;

			tempText = GameObject.Find("Class" + (i + 1) + "Description").GetComponent<Text>();
			tempString = classDescriptions[i];
			tempText.text = tempString;

			tempText = GameObject.Find("Class" + (i + 1) + "Stats").GetComponent<Text>();
			for (int j = 0; j < gladhanderStats.Length; j++) 
			{
				if (j == 0 && i == 0)
				{
					tempText.text = tempText.text + "Rhetoric: " + gladhanderStats[j] + "\n";
				}
				else if (j == 1 && i == 0)
				{
					tempText.text = tempText.text + "Image: " + gladhanderStats[j] + "\n";
				}
				else if (j == 2 && i == 0)
				{
					tempText.text = tempText.text + "Diplomacy: " + gladhanderStats[j] + "\n";
				}
				else if (j == 0 && i == 1)
				{
					tempText.text = tempText.text + "Rhetoric: " + chiefStats[j] + "\n";
				}
				else if (j == 1 && i == 1)
				{
					tempText.text = tempText.text + "Image: " + chiefStats[j] + "\n";
				}
				else if (j == 2 && i == 1)
				{
					tempText.text = tempText.text + "Diplomacy: " + chiefStats[j] + "\n";
				}
				else if (j == 0 && i == 2)
				{
					tempText.text = tempText.text + "Rhetoric: " + sophistStats[j] + "\n";
				}
				else if (j == 1 && i == 2)
				{
					tempText.text = tempText.text + "Image: " + sophistStats[j] + "\n";
				}
				else if (j == 2 && i == 2)
				{
					tempText.text = tempText.text + "Diplomacy: " + sophistStats[j] + "\n";
				}
			}
		}
	}

	public void CheckTogglesAndSaveInfo()
	{
		if (class1toggle.isOn && !class2toggle.isOn && !class3toggle.isOn)
		{
			GameInformation.PlayerClass = new BaseGladhanderClass();
			GameInformation.Rhetoric = tempGladhander.Rhetoric;
			GameInformation.Image = tempGladhander.Image;
			GameInformation.Diplomacy = tempGladhander.Diplomacy;

			GameInformation.PlayerMove1 = new AttackAbility ();
			GameInformation.PlayerMove2 = new ToMyAide ();
			GameInformation.PassiveAbility = new RazzleDazzle();
		} 
		else if (!class1toggle.isOn && class2toggle.isOn && !class3toggle.isOn)
		{
			GameInformation.PlayerClass = new BaseChiefClass();
			GameInformation.Rhetoric = tempChief.Rhetoric;
			GameInformation.Image = tempChief.Image;
			GameInformation.Diplomacy = tempChief.Diplomacy;

			GameInformation.PlayerMove1 = new AttackAbility ();
			GameInformation.PlayerMove2 = new BigStick ();
			GameInformation.PassiveAbility = new GlowerOfHate();
		} 
		else if (!class1toggle.isOn && !class2toggle.isOn && class3toggle.isOn)
		{
			GameInformation.PlayerClass = new BaseSophistClass();
			GameInformation.Rhetoric = tempSophist.Rhetoric;
			GameInformation.Image = tempSophist.Image;
			GameInformation.Diplomacy = tempSophist.Diplomacy;

			GameInformation.PlayerMove1 = new AttackAbility ();
			GameInformation.PlayerMove2 = new Tirade ();
			GameInformation.PassiveAbility = new QuestionableLogic();
		}

		GameInformation.PlayerLevel = 1;
		GameInformation.PlayerName = inputField.text;
		GameInformation.CurrentXP = 0;
		GameInformation.RequiredXP = 100;
		GameInformation.WonFight = false;
		SaveInformation.SaveAllInformation();
	}


}
