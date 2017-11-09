using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseStatItem : BaseItem
{

    private int rhetoric;
    private int image;
    private int diplomacy;

    public int Diplomacy
    {
        get { return diplomacy; }
        set { diplomacy = value; }
    }

    public int Rhetoric
    {
        get { return rhetoric; }
        set { rhetoric = value; }
    }

    public int Image
    {
        get { return image; }
        set { image = value; }
    }
}
