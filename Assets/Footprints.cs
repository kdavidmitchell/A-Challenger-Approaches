using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footprints : MonoBehaviour 
{

	private float lifeTime = 3f;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		lifeTime -= Time.deltaTime;
		transform.Translate (Time.deltaTime * 0.3f, Time.deltaTime * 0.3f, 0); // move forward
		transform.Rotate (0, 0, -Time.deltaTime * 0.5f); // turn a little

		if (lifeTime <= 0)
		{
			Destroy(gameObject);
		}	
	}
}
