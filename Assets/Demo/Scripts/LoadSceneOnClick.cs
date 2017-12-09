using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour 
{

	public void LoadBattleDemoScene()
	{
		SceneManager.LoadScene(3);
	}

	public void LoadCharacterCreationScene()
	{
		SceneManager.LoadScene(1);
	}

	public void LoadMapScene()
	{
		SceneManager.LoadScene(2);
	}
}
