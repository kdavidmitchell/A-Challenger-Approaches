using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {

    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static int Rhetoric { get; set; }
    public static int Image { get; set; }
    public static int Diplomacy { get; set; }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

	
}
