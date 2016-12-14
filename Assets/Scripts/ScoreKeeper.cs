using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public int score=0;
	// Use this for initialization

	void Start () {
		DontDestroyOnLoad (gameObject);
	}

	public void IncrementScore()
	{
		score++;
		print("You scored. Your current score is " + score);
	}
}
