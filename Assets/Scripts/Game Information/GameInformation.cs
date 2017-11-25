using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {

	public static bool IsMale { get; set; }
	public static string PlayerBio { get; set; }
    public static BaseClothing Clothing1 { get; set; } 
    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static int Rhetoric { get; set; }
    public static int Image { get; set; }
    public static int Diplomacy { get; set; }
    public static float CurrentXP { get; set; }
    public static float RequiredXP { get; set; }
    public static List<Skill> PlayerSkills { get; set; }
    public static int Currency { get; set; }

	public static float PlayerHealth { get; set; }
	public static float PlayerEnergy { get; set; }

	public static BaseAbility PlayerMove1 = new AttackAbility();
	public static BaseAbility PlayerMove2 = new ToMyAide();
	public static BaseAbility PassiveAbility = new RazzleDazzle();

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

	
}
