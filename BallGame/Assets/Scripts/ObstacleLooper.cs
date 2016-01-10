using UnityEngine;
using System.Collections;

public class ObstacleLooper : MonoBehaviour
{
		float WallMax = 3f;
		float WallMin = 0.8f;
		//Setting the initial position of the obstacles
		void Start ()
		{
				GameObject[] Walls = GameObject.FindGameObjectsWithTag ("Wall");//finding the obstacles
		
				foreach (GameObject wall in Walls) {
						Vector3 pos = wall.transform.position;//taking the walls' position
						pos.y = Random.Range (WallMin, WallMax);// giving them a random vertical value between the set variables
						wall.transform.position = pos;// setting them the position
				}
		}

		void OnTriggerEnter (Collider collider)
		{
		
				Vector3 pos = collider.transform.position;//taing the collider's position
		
				pos.x += 15f;//giving the collider a new position with a fixed value
		
				if (collider.tag == "Wall") {
						pos.y = Random.Range (WallMin, WallMax);//giving it a random vertical position
				} 

				collider.transform.position = pos; //setting the positioin again
		
		}
}