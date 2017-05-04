using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1MotionController : MonoBehaviour {

	public bool inPlay = false;
	public float speed;
	public float verticalRange;

	public float inPlayX;
	public float outOfPlayX;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		Vector3 currentPos = transform.position;
		if (inPlay)
		{
			currentPos.y = Mathf.Sin(Time.time * speed) * verticalRange;            
			if(currentPos.x != inPlayX)
			{
				currentPos.x = Mathf.Lerp(currentPos.x, inPlayX, Time.deltaTime * speed);
			}

		}
		else
		{
			if (currentPos.x != outOfPlayX)
			{
				currentPos.x = Mathf.Lerp(currentPos.x, outOfPlayX, Time.deltaTime * speed);
			}
		}
		transform.position = currentPos;
	}
}