using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour {

    private BaseCharacterClass class1 = new BaseGladhanderClass();
    private BaseCharacterClass class2 = new BaseSophistClass();
    private BaseCharacterClass class3 = new BaseChiefClass();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescription);
        GUILayout.Label("Rhetoric: " + class1.Rhetoric.ToString());
        GUILayout.Label("Image : " + class1.Image.ToString());
        GUILayout.Label("Diplomacy: " + class1.Diplomacy.ToString());

        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescription);
        GUILayout.Label("Rhetoric: " + class2.Rhetoric.ToString());
        GUILayout.Label("Image : " + class2.Image.ToString());
        GUILayout.Label("Diplomacy: " + class2.Diplomacy.ToString());

        GUILayout.Label(class3.CharacterClassName);
        GUILayout.Label(class3.CharacterClassDescription);
        GUILayout.Label("Rhetoric: " + class3.Rhetoric.ToString());
        GUILayout.Label("Image : " + class3.Image.ToString());
        GUILayout.Label("Diplomacy: " + class3.Diplomacy.ToString());
    }
}
