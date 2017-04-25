using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotionController : MonoBehaviour {

    public float speed;
    public Vector3 direction;
    public Vector3 origin;


	void Update () {
        transform.Translate(direction * speed * Time.deltaTime);
	}

    void OnTriggerEnter2D()
    {
        transform.position = origin;
    }
}
