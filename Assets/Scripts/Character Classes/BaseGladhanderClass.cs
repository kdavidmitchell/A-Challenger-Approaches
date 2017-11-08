using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGladhanderClass: BaseCharacterClass
{

    public BaseGladhanderClass()
    {
        CharacterClassName = "Gladhander";
        CharacterClassDescription = "You are a well of infinite charm. A good smile, a strong chin, and a head of neatly coifed hair: " +
            "these are the tools of the gladhander. Make friends out of enemies, summon your most " +
            "devout constituents to aid you, and flash those pearly whites.";

        Rhetoric = 7;
        Diplomacy = 8;
        Image = 9;
    }
}
