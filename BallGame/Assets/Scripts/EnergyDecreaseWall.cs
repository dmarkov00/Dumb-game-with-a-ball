using UnityEngine;
using System.Collections;

public class EnergyDecreaseWall : MonoBehaviour {
	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Player") {// check if the object with tag "Player" have collided with the obstacle
			Energy.DecreaseEnergy();// calling the function DecreaseEnergy() from the Energy.cs file
			}
	}
}
