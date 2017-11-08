using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseChiefClass : BaseCharacterClass
{

    public BaseChiefClass()
    {
        CharacterClassName = "Chief-of-Staff";
        CharacterClassDescription = "You have no need to speak softly, because you have the biggest stick around. " +
            "Militarily minded and calculatingly cold, you, and you alone, have the strength to do what needs to be done. " +
            "Shout at your enemies until they fall into a daze, guard yourself with an army of aides, and show that diplomacy " +
            "really just means 'force'.";

        Rhetoric = 8;
        Diplomacy = 9;
        Image = 7;
    }	
}
