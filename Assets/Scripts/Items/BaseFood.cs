using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFood : BaseStatItem
{

	public enum FoodTypes
    {
        HEALTH,
        ENERGY
    }

    private FoodTypes foodType;
    private int modifierID;

    public FoodTypes FoodType { get; set; }
    public int ModifierID { get; set; }


    //example constructor
    public BaseFood()
    {
        ItemName = "Food";
        ItemDescription = "This is some good eats.";
        ItemID = Random.Range(1, 101);
        FoodType = FoodTypes.HEALTH;
    }
}
