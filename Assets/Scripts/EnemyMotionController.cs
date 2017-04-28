using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotionController : MonoBehaviour {

    public float speed;
    public Vector3 direction;
	public Vector3 origin;
	float timer;


	void Update () {
		timer += Time.deltaTime;
		if (timer >= 12) {
			transform.Translate (direction * speed * Time.deltaTime);

		}
	}

    void OnTriggerEnter2D()
    {
		//had to hard code the position here. For some reason setting origin as class variable always caused object to appear in (0,0,0)
		transform.position = new Vector3(11.0f,0.0f,0.0f);
    }
}
