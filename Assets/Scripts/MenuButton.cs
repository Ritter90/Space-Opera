using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour {

	public GameController gC;
	public static float timer;
	void OnMouseDown()
	{
		Debug.Log("Button Clicked");
		gC.StartGame();
		timer = Time.time;
	}
}