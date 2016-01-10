using UnityEngine;
using System.Collections;

public class CameraTracksBall : MonoBehaviour
{
		//Here we have made the camera to track the player ball
		Transform player; //Declaring object from the class Transform
	
		float offsetX;
 
		// Use this for initialization
		void Start ()
		{
				GameObject player_go = GameObject.FindGameObjectWithTag ("Player");//Selecting the gameobject with tag player
		
				if (player_go == null) {// checking if there is no player
						Debug.LogError ("Couldn't find an object with tag 'Player'!");
						return;
				}
		
				player = player_go.transform;// taking the gameobject's(player_go) transform property and setting it to another variable
		
				offsetX = transform.position.x - player.position.x;//Here we set the player's offset from the screen when we substract the position
		}                                                      //of the camera from the player's position on the x-axis
	
		// Update is called once per frame
		void Update ()
		{
				if (player != null) {
						Vector3 pos = transform.position; //taking the position of the camera
						pos.x = player.position.x + offsetX;//setting the camera position when summing the player position and the offset 
						transform.position = Vector3.Lerp (transform.position, pos, Time.deltaTime);//setting the position again using the Lerp function
				}																			//and making a smooth movement of the camera
				// from its position(transform.postion)																					//to player postion(pos)- every frame(Time.deltaTime)
		}
}

