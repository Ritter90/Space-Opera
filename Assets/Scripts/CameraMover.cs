using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

	public Vector3 aimPos = Vector3.zero;
	public float size;
	public float speed;
	public bool moving;

	private Camera cam;

	void Start()
	{
		cam = gameObject.GetComponent<Camera>();
	}

	// Update is called once per frame
	void Update () {
		if(moving)
		{
			transform.position = Vector3.Lerp(transform.position, aimPos, speed * Time.deltaTime);
			cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, size, speed * Time.deltaTime);
		}

		if(transform.position == aimPos && cam.orthographicSize == size)
		{
			moving = false;
		}
	}

	public void MoveToPosition(Vector3 newPos, float newSize, float newSpeed)
	{
		aimPos = newPos;
		size = newSize;
		speed = newSpeed;
		moving = true;
	}
}