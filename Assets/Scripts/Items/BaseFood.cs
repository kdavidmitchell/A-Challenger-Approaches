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
}
