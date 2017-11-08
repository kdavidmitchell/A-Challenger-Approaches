using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour
{

    void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.ItemID.ToString());
        Debug.Log(newWeapon.WeaponType.ToString());
        Debug.Log(newWeapon.Rhetoric.ToString());
        Debug.Log(newWeapon.Image.ToString());
        Debug.Log(newWeapon.Diplomacy.ToString());
    }

    private BaseWeapon newWeapon;
    //private string[] weaponNames = new string[6] { "The Biggest Stick" };

    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();

        //assign name
        newWeapon.ItemName = "W" + Random.Range(1, 101);
        //create weapon description
        newWeapon.ItemDescription = "This is a new weapon.";
        //weapon ID
        newWeapon.ItemID = Random.Range(1, 101);
        //stats
        newWeapon.Rhetoric = Random.Range(1, 4);
        newWeapon.Image = Random.Range(1, 4);
        newWeapon.Diplomacy = Random.Range(1, 4);
        //choose type of weapon
        ChooseWeaponType();
        //modifier ID
        newWeapon.ModifierID = Random.Range(1, 4);
    }

    private void ChooseWeaponType()
    {
        int randomTemp = Random.Range(1, 5);

        if (randomTemp == 1)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.STICK;
        }
        else if (randomTemp == 2)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.MICROPHONE;
        }
        else if (randomTemp == 3)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.CELLPHONE;
        }
        else if (randomTemp == 4)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.BRIEFCASE;
        }
    }
}
