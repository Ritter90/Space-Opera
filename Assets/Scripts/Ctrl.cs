using UnityEngine;
using System.Collections;

public class Ctrl : MonoBehaviour {

	public float speed = 15.5f;
	public Quaternion originalRotationValue;
	public Quaternion maxUpRotationValue;
	public Quaternion minDownRotationValue;
	public float rotationResetSpeed = 1f;
	public float rotationSpeed = 1f;
    public float upperBound = 5f;
    public float lowerBound = -5f;
	public float rotationBound = 0.2f;

	void start(){
		originalRotationValue = transform.rotation; // save the initial rotation

	}

	void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Vertical");
        MoveShipPosition(input);
		RotateShip (input);

    }

	private void MoveShipPosition(float input)
	{

		float newYPos = transform.position.y + (speed * Time.deltaTime * input);
		if (newYPos > upperBound)
		{
			transform.position = new Vector3(transform.position.x, upperBound);
		}
		else if (newYPos < lowerBound)
		{
			transform.position = new Vector3(transform.position.x, lowerBound);
		}
		else
		{
			transform.position = new Vector3(transform.position.x, newYPos);
		}


	}


	private void RotateShip(float input){
		if (input != 0) {
			if (transform.rotation.z > -rotationBound && transform.rotation.z < rotationBound) {	
				gameObject.transform.Rotate (0, 0, 1 * rotationSpeed * input);
			}

		} else {
			gameObject.transform.rotation = originalRotationValue; 
		}

	}
		
}
