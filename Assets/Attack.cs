using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Apply in Enemy

public class Attack : MonoBehaviour {

	private int playerscore = 0;
	private BorrowUpdateLoadnxtLevel borrowscript;


	void Awake()
	{
		borrowscript = GameObject.FindObjectOfType<BorrowUpdateLoadnxtLevel> (); // Access variable from other script
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals ("Bullet")) {
			Destroy (col.gameObject);

			Destroy (gameObject);
			playerscore = playerscore + 10;
			borrowscript.UpdateScore (playerscore);  // updates the score to other script by Update score which is used in ther script


		}
	}
}
