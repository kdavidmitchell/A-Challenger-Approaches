using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewClothing : MonoBehaviour 
{

	private BaseClothing newClothing;
	private string[] itemNames = new string[4] {"Peasant", "Working-Class", "Completely Average", "Stunning"};
	private string[] itemDescriptions = new string[2] {"A cool new item!", "A completely average item."};

	// Use this for initialization
	void Start () {
		CreateClothing();
		Debug.Log(newClothing.ItemName);
        Debug.Log(newClothing.ItemDescription);
        Debug.Log(newClothing.ItemID.ToString());
        Debug.Log(newClothing.ClothingType.ToString());
        Debug.Log(newClothing.Rhetoric.ToString());
        Debug.Log(newClothing.Image.ToString());
        Debug.Log(newClothing.Diplomacy.ToString());
		
	}

	private void CreateClothing()
	{
		newClothing = new BaseClothing();
		newClothing.ItemName = itemNames[Random.Range(0,itemNames.Length)] + " Item";
		newClothing.ItemID = Random.Range(1,101);
		newClothing.ItemDescription = itemDescriptions[Random.Range(0,itemDescriptions.Length)];
		ChooseItemType();
		newClothing.Rhetoric = Random.Range(1,4);
		newClothing.Image = Random.Range(1,4);
		newClothing.Diplomacy = Random.Range(1,4);
	}

	private void ChooseItemType()
	{
		int randomTemp = Random.Range(1,6);
		if (randomTemp == 1)
		{
			newClothing.ClothingType = BaseClothing.ClothingTypes.HEAD;
		}
		if (randomTemp == 2)
		{
			newClothing.ClothingType = BaseClothing.ClothingTypes.BODY;
		}
		if (randomTemp == 3)
		{
			newClothing.ClothingType = BaseClothing.ClothingTypes.NECK;
		}
		if (randomTemp == 4)
		{
			newClothing.ClothingType = BaseClothing.ClothingTypes.EARRING;
		}
		if (randomTemp == 5)
		{
			newClothing.ClothingType = BaseClothing.ClothingTypes.RING;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
