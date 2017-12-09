using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapFunctions : MonoBehaviour 
{

	public Image player;
	public GameObject footprints;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void Wander()
	{
		Instantiate(footprints, player.transform.position, Quaternion.identity);
	}
}
