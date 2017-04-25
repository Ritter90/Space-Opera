﻿using UnityEngine;
using System.Collections;

public class Ctrl : MonoBehaviour {

	public float speed = 15.5f;

    public float upperBound = 5f;
    public float lowerBound = -5f;

	void FixedUpdate()
	{
        float newYPos = transform.position.y + (speed * Time.deltaTime * Input.GetAxisRaw("Vertical"));
        if (newYPos > upperBound)
        {
            transform.position = new Vector3(transform.position.x, upperBound);
        }
        else if(newYPos < lowerBound)
        {
            transform.position = new Vector3(transform.position.x, lowerBound);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, newYPos);
        }
	}
}
