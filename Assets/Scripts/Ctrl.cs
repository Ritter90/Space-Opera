using UnityEngine;
using System.Collections;

public class Ctrl : MonoBehaviour {

	public float speed = 15.5f;

	void FixedUpdate()
	{
		Debug.Log ("FixedUpdate" + Time.time);
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;

		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
	}

	void Update(){
		Debug.Log ("Update" + Time.time);
	}
}
