using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{

		static public int score = 0;
		static int highScore = 0;

		static public void AddPoint ()
		{
				score++; // adding score on every call of AddPoint()
				if (score > highScore) {
						highScore = score;//setting the highest score
				}
				if (Time.timeScale == 0) {// if the player is dead and the game is paused score is set to 0
						score = 0;
				}
		}

		void Start ()
		{
				highScore = PlayerPrefs.GetInt ("highScore", 0);//getting the highest scor
		}

		void onDestroy ()
		{
				PlayerPrefs.SetInt ("highScore", highScore);//setting the highest score
		}

		void Update ()
		{
				guiText.text = "Score: " + score + "\nHighScore: " + highScore;// showing the score and highscore on the screen
				onDestroy ();
		}
	
}
