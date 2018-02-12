using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseClothing : BaseItem
{

	public enum ClothingTypes
    {
        HEAD,
        BODY,
        NECK,
        EARRING,
        RING
    }

    private ClothingTypes clothingType;
    private int modifierID;

    public ClothingTypes ClothingType { get; set; }
    public int ModifierID { get; set; }
}
