using UnityEngine;
using System.Collections;

public class Ctrl : MonoBehaviour {

	public float speed = 15.5f;

    public float upperBound = 5f;
    public float lowerBound = -5f;

	void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Vertical");
        MoveShipPosition(input);
    }

    private void MoveShipPosition(float input)
    {
        float newYPos = transform.position.y + (speed * Time.deltaTime * input);
        if (newYPos > upperBound)
        {
			transform.rotation = Vector3.Angle (Vector3 (0, 0, 0), Vector3 (0, 0, -10));
            transform.position = new Vector3(transform.position.x, upperBound);
        }
        else if (newYPos < lowerBound)
        {
			transform.rotation = new Vector3 (0,0,-10);
            transform.position = new Vector3(transform.position.x, lowerBound);
        }
        else
        {
			transform.rotation = new Vector3 (0,0,0);
            transform.position = new Vector3(transform.position.x, newYPos);
        }
    }
}
