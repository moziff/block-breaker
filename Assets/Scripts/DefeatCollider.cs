using UnityEngine;
using System.Collections;

public class DefeatCollider : MonoBehaviour {
	// Use this for initialization

	private LevelManager levelmanager;

	void Start(){
		levelmanager = GameObject.FindObjectOfType<LevelManager> ();
	}

	void OnTriggerEnter2D(Collider2D trigger){
		levelmanager.LoadLevel ("Win Screen");
	}
}
