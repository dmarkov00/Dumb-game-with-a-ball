using UnityEngine;
using System.Collections;

public class AddEnergyAndScore : MonoBehaviour {
	void OnTriggerEnter(Collider collider) { 
				if (collider.tag == "Player") {//check if the collider is with tag "Player"
						Score.AddPoint (); //Calling the method AddPoint from Score.cs file
						Energy.AddEnergy();//Calling the method AddEnergy from Energy.cs file
				}
		}
}


