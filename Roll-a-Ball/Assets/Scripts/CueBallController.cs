using UnityEngine;
using System.Collections;

public class CueBallController : MonoBehaviour 
{
	public float speed;
	private Vector3 movement = new Vector3(0.0f, 0.0f, 0.0f);

	void FixedUpdate()
	{
		//float moveVertical = Input.GetAxis("Vertical");
		//float moveHorizontal = Input.GetAxis("Horizontal");

		//movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rigidbody.AddForce (movement * speed * Time.deltaTime, ForceMode.VelocityChange);
		speed = 0;
	}

	void updateMovement(Vector3 direction){
		movement = new Vector3 (direction.x, 0.0f, direction.y);
	}

	void updateSpeed(float newSpeed){
		speed = newSpeed;
	}
}
