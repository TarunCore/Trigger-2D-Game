using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Apply this in enemy
public class Health : MonoBehaviour {


	public static int PlayerHealth = 100;
	public int InternalHealth;
	public int PlayerDamage;
	public GameObject HealthDisplay;
	private menu hud; // name of other script (here"menu")
	[Space]
	[Header("UI")]
	public string levelnameforuirestartbutton;
	public string levelwhenplayerdie;



	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals ("Player")) 
		{
			PlayerHealth -= PlayerDamage;
		}
	}
		

	void Update () {
		
		HealthDisplay.GetComponent<Text> ().text = "Health: " + PlayerHealth;
		if (PlayerHealth <= 0) {
			SceneManager.LoadScene (levelwhenplayerdie);
			PlayerHealth = 100;

		}

	
	}

	// Reason for using this here is to access "PlayerHealth" while 'restarting'.
	public void Restartl2() // Restarting level with player health for UI canvas
	{
		PlayerHealth = 100;
		SceneManager.LoadScene (levelnameforuirestartbutton);
	}



}
