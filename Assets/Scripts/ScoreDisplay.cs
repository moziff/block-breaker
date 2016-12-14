﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	private Text text;


	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		int score = GameObject.FindObjectOfType<ScoreKeeper>().score;
		text.text = "Score: "+ score;
	}
}
