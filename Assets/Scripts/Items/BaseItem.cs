using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem
{

    private string itemName;
    private string itemDescription;
    private int itemID;

    public enum ItemTypes
    {
        CLOTHING,
        WEAPON,
        FOOD
    }

    private ItemTypes itemType;

    public string ItemName { get; set; }
    public string ItemDescription { get; set; }
    public int ItemID { get; set; }
    public ItemTypes ItemType { get; set; }
}
