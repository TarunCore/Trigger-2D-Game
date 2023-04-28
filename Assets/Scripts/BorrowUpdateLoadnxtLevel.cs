using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Apply in win point or empty game object
// This script just borrows variables("playerscore") from "Attack" script

public class BorrowUpdateLoadnxtLevel : Attack {

	public string levelname;

	public int currentScore;
	public GameObject HealthDisplay;
	//start()



	//update()
	public void UpdateScore (int score) { // Updates score to "score" through UpdateScore

		currentScore += score;
		HealthDisplay.GetComponent<Text> ().text = "Score: " + currentScore;



	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals ("Player") && currentScore >= 100) {

			SceneManager.LoadScene (levelname);


		}
	}
}