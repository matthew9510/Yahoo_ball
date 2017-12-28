using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void doQuit(){
		Debug.Log ("has quit game");
		Application.Quit ();
	}
	public void goToCredits(){
		SceneManager.LoadScene("Credits",LoadSceneMode.Single);
	}
	public void goToGame(){
		SceneManager.LoadScene("Main",LoadSceneMode.Single);
	}
	public void goToInstruction(){
		SceneManager.LoadScene("Instruct",LoadSceneMode.Single);
	}
	public void goToMenu(){
		SceneManager.LoadScene ("Intro", LoadSceneMode.Single);
	}
}
