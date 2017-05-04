using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotionController : MonoBehaviour {

    public float speed;
    public Vector3 direction;
	public Vector3 origin;



	void Update () {
		MenuButton.timer += Time.deltaTime;
		if (MenuButton.timer >= 12) {
			transform.Translate (direction * speed * Time.deltaTime);

		}
	}

    void OnTriggerEnter2D()
    {
		transform.position = new Vector3(11.0f,0.0f,0.0f);
    }
}
