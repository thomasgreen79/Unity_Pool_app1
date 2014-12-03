using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GUIText scoreText;
	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore ();
	}

	public void IncrementScore(){
		score++;
		UpdateScore ();
	}

	void UpdateScore() {
		scoreText.text = "Score: " + score.ToString ();
	}
}
