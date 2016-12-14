using UnityEngine;
using System.Collections;

public class BrickSpace : MonoBehaviour {
	private LevelManager lm;
	// Use this for initialization
	void Start () {
		lm = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.childCount == 0) {
			lm.LoadNextScene();
		}
	}
}
