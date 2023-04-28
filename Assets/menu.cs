using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class menu : MonoBehaviour {

	public string desiredlevelname;

    // Use this for initialization
    void Start () {
    }
// Update is called once per frame
void Update () {
}
public void StartGame()
{
Application.LoadLevel(1);
}
public void Quit()
{
Application.Quit();
}
	public void loaddesiredlevel () {
		SceneManager.LoadScene (desiredlevelname);

	}

	public void MainMenu()
	{
		Application.LoadLevel (0);
	}
}
