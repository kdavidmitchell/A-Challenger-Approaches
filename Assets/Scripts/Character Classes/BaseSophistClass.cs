using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSophistClass : BaseCharacterClass
{

    public BaseSophistClass()
    {
        CharacterClassName = "Sophist";
        CharacterClassDescription = "You've always known that the pen is mightier than the sword. " +
            "In vocal power and eloquence, you have no equal. Bore your enemies to death with long " +
            "speeches, lull them to sleep with the rich cadence of your voice, or outsmart their every move.";

        Rhetoric = 9;
        Diplomacy = 7;
        Image = 8;
    }
	
}
