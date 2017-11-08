using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseStatItem
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

}
