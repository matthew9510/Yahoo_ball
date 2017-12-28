using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	private int score = 0;
	private int highScore = 0;

	public Text score1;
	public Text finalScore;
	public Text highScore1;
	public bool win = false;

    void OnCollisionEnter(Collision coll){
		if(coll.gameObject.CompareTag("Pickup1")){
			score += 10;
			score1.text = "Score: " + score;
		}
        if(coll.gameObject.CompareTag("Pickup2")){
            score += 50;
            score1.text = "Score: " + score;
        }
		if (coll.gameObject.CompareTag ("Pickup3")) {
			score -= 20;
			score1.text = "Score: " + score;
		}
		if(coll.gameObject.CompareTag("End")){
			gameObject.active = false;
			finalScore.text = "Game Over\nScore: " + score;
			if(highScore <= score){
				highScore = score;
				PlayerPrefs.SetInt ("HighScore", highScore);
				highScore1.text = "High Score: " + highScore;
			}
			Debug.Log("Win!");
		}
	}

	// Use this for initialization
	void Start () {
		score1.GetComponent<Text> ();
		highScore = PlayerPrefs.GetInt ("HighScore");
		highScore1.text = "High Score: " + highScore;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
