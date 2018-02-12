using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseItem
{

	public enum WeaponTypes
    {
        STICK,
        MICROPHONE,
        CELLPHONE,
        BRIEFCASE
    }

    private WeaponTypes weaponType;
    private int modifierID;

    public WeaponTypes WeaponType { get; set; }
    public int ModifierID { get; set; }

    public BaseWeapon()
    {
        ItemName = "Briefcase of the Sycophant";
        ItemDescription = "A sad-looking briefcase belonging to a once-employed yuppie.";
        ItemID = Random.Range(1, 101);
        WeaponType = WeaponTypes.BRIEFCASE;
    }

}
