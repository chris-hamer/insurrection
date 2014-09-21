using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	bool pauseGame = false;

	public void Pause () { 
		Time.timeScale = 0;
		pauseGame = true;
		Camera.main.GetComponent<MouseLook>().enabled = false;
		GameObject.FindGameObjectWithTag("Player").GetComponent<MouseLook> ().enabled = false;
		Debug.Log ("Game is paused");
	}
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("p")) {
			pauseGame = !pauseGame;

			if(pauseGame == true){
				Pause ();
			}
		

			if (pauseGame == false) {
				Time.timeScale = 1;
				pauseGame = false;
				Camera.main.GetComponent<MouseLook> ().enabled = true;
				GameObject.Find ("First Person Controller").GetComponent<MouseLook> ().enabled = true;
			}
		}
	}
}