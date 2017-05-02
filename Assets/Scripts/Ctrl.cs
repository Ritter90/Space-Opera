using UnityEngine;
using System.Collections;

public class Ctrl : MonoBehaviour {

	public float speed = 15.5f;
	public Quaternion originalRotationValue;
	public Quaternion maxUpRotationValue;
	public Quaternion minDownRotationValue;
	float rotationResetSpeed = 0.1f;
    public float upperBound = 5f;
    public float lowerBound = -5f;


	void start(){
		originalRotationValue = transform.rotation; // save the initial rotation

	}

	void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Vertical");
        MoveShipPosition(input);
    }

	void Update (){
		if (Input.GetKey ("down")) {
			if (transform.rotation.z > -0.4) {
				gameObject.transform.Rotate(0, 0, -1);
			}

		}

		else if (Input.GetKey ("up")) {
			
			if (transform.rotation.z < 0.4) {
				gameObject.transform.Rotate (0, 0, 1);
			}

		} 
		else {
				gameObject.transform.rotation = Quaternion.Slerp (transform.rotation, originalRotationValue, Time.time * rotationResetSpeed);

		}
				
	}

    private void MoveShipPosition(float input)
    {


        float newYPos = transform.position.y + (speed * Time.deltaTime * input);
        if (newYPos > upperBound)
        {
		//	transform.Rotate(0, 0, 10);
		//	print ("Up" + transform.rotation);
            transform.position = new Vector3(transform.position.x, upperBound);
        }
        else if (newYPos < lowerBound)
        {
		//	transform.Rotate(0, 0, -10);
		//	print ("Down" + transform.rotation);
		//	transform.rotation = new Vector3 (0,0,-10);
            transform.position = new Vector3(transform.position.x, lowerBound);
        }
        else
        {
		//	transform.Rotate(0, 0, 0);
		//	print ("Stay" + transform.rotation);
		//	transform.rotation = new Vector3 (0,0,0);
            transform.position = new Vector3(transform.position.x, newYPos);
        }
    }
}
