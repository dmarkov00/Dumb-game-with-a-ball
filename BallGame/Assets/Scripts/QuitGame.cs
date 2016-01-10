using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour
{
		void Update ()
		{
				if (Input.GetKey (KeyCode.Escape)) {//checking if Esc button is pressed
						Application.Quit ();// quiting the game

				}
		}
}
