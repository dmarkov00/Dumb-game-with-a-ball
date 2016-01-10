using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
		float maxSpeed = 5f;
		float BoudaryCorrection = 0.2f;
		float maxPos;

		void Update ()
		{
				//The movement of the player
				Vector3 pos = transform.position;//taking position
				//
				pos.y += Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime;//moving vertically 

				maxPos = pos.x;// setting the max value 

				pos.x += Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime;//moving horizontally

				if (pos.x < maxPos) { //Checking if the value of current position is smaller than  the maximal 
						pos.x = maxPos; //Restricting player boundries 
				}
				//Restrict the player to camera boundries y-axis(vertical)
				if (pos.y + BoudaryCorrection > Camera.main.orthographicSize) {// using the camera's size as a maximal vertical boundary and checking if the current position exceeds it
						pos.y = Camera.main.orthographicSize - BoudaryCorrection;// setting the position at the camera boundaries
				}
				if (pos.y - BoudaryCorrection < -Camera.main.orthographicSize) { //using the camera's size as a maximal vertical boundary and checking if the current position exceeds it
						pos.y = -Camera.main.orthographicSize + BoudaryCorrection;//setting the position at the camera boundaries
				}

				// Finally, update our position!!
				transform.position = pos;
		}
	

}
