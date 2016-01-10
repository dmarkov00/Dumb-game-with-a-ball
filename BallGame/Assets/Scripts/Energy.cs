using UnityEngine;
using System.Collections;

public class Energy : MonoBehaviour
{
		public static float energy = 1003f;
		float energyLostPerSecond = 30f;

		static public void AddEnergy ()
		{
				energy = energy + 40f;// adding 40 energy on every call of the function
		}

		static public void DecreaseEnergy ()
		{
				energy = energy - 40f;// substract 40 energy on every call of the function
		}

		public void PlayerDeath ()
		{
		
				Time.timeScale = 0;//bassicaly pause the game making time stop
				Score.score = 0;//stting the score to 0 from int the file Score.cs
				GetComponent<SpriteRenderer> ().enabled = true;// Enabling the GameOver image

		}

		void Update ()
		{
				float energyLostPerFrame;
				guiText.text = "Energy: " + (int)energy; //Attaching the text to te screen
				energyLostPerFrame = energyLostPerSecond * Time.deltaTime; // obtaining the energy lost per frame when multiplying by Time.deltaTime(making thigs frame rate independent)
				energy -= energyLostPerFrame;//geting the energy

				if (energy <= 1) { //if energy less than 1 calling PlayerDeath() function

						PlayerDeath ();
	
				}

				if (Time.timeScale == 0 && Input.GetKeyDown (KeyCode.UpArrow)) { //check if the time is stopped and if the up arrow is pressed
		
						Application.LoadLevel (Application.loadedLevel);//resetting the whole scene
						GetComponent<SpriteRenderer> ().enabled = false;//disabling the GameOver image
						energy = 1003;//Setting energy at starting position

				}

		}
}
	
		

	