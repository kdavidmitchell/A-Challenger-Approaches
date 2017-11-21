using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5f;

	// Use this for initialization
	void Start ()
    {
        		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float translationX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float translationY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(translationX, translationY, 0);
        	
	}
}
