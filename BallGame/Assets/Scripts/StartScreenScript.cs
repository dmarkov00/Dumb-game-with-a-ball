using UnityEngine;
using System.Collections;

public class StartScreenScript : MonoBehaviour {

	static bool sawOnce = false;

	// Use this for initialization
	void Start () {
		if(!sawOnce) {//checking if the start screen have been shown
			GetComponent<SpriteRenderer>().enabled = true;//enable the srat screen
			Time.timeScale = 0;//pause the game
		}

		sawOnce = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale==0 && (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)||Input.GetKeyDown(KeyCode.LeftArrow)
		                         ||Input.GetKeyDown(KeyCode.RightArrow)) ) {//chicking in the buttons are clicked
			Time.timeScale = 1;//unpause the game
			GetComponent<SpriteRenderer>().enabled = false;//disable the start screen

		}
	}
}
