using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseItem
{

    private string itemName;
    private string itemDescription;
    private int itemID;
    private int rhetoric;
    private int image;
    private int diplomacy;

    public enum ItemTypes
    {
        CLOTHING,
        WEAPON,
        FOOD
    }

    private ItemTypes itemType;

    public BaseItem(Dictionary<string, string> itemDictionary)
    {
        itemName = itemDictionary["ItemName"];
        itemDescription = itemDictionary["ItemDescription"];
        itemID = int.Parse(itemDictionary("ItemID"));
        itemType = (ItemTypes)System.Enum.Parse(typeof(BaseItem.ItemTypes), itemDictionary["ItemType"].ToString());
    }

    public string ItemName { get; set; }
    public string ItemDescription { get; set; }
    public int ItemID { get; set; }
    public ItemTypes ItemType { get; set; }
    public int Rhetoric { get; set; }
    public int Image { get; set; }
    public int Diplomacy { get; set; }
}
