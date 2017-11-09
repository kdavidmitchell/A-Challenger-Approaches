using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewFood : MonoBehaviour 
{

	private BaseFood newFood;
	//private string[] itemNames = new string[x] {x number of strings in here};

	// Use this for initialization
	void Start () {
		CreateFood();
		Debug.Log(newFood.ItemName);
        Debug.Log(newFood.ItemDescription);
        Debug.Log(newFood.ItemID.ToString());
        Debug.Log(newFood.FoodType.ToString());
	}
	
	private void CreateFood()
	{
		newFood = new BaseFood();
		newFood.ItemName = "Food";
		newFood.ItemDescription = "This is some good eats.";
		newFood.ItemID = Random.Range(1,101);
		ChooseFoodType();

	}

	private void ChooseFoodType()
	{
		int randomTemp = Random.Range(0,2);
		if (randomTemp == 0)
		{
			newFood.FoodType = BaseFood.FoodTypes.HEALTH;
		}
		if (randomTemp == 1)
		{
			newFood.FoodType = BaseFood.FoodTypes.ENERGY;
		}
	}
}
