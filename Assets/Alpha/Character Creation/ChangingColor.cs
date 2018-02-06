using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingColor : MonoBehaviour 
{

	public GameObject panel;
	public SpriteRenderer head;
	public Image squareHeadDisplay;

	public Color[] colors;

	public int colorIndex = 1;

	void Update()
	{
		squareHeadDisplay.color = head.color;

		for (int i = 0; i < colors.Length; i++)
		{
			if (i == colorIndex)
			{
				head.color = colors[i];
			}
		}
	}

	public void ChangePanelState(bool state)
	{
		panel.SetActive(state);
	}

	public void ChangeHeadColor(int index)
	{
		colorIndex = index;
	}
}
