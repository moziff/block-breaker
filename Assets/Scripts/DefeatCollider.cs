using UnityEngine;
using System.Collections;

public class DefeatCollider : MonoBehaviour {
	// Use this for initialization

	public LevelManager levelmanager;

	void OnTriggerEnter2D(Collider2D trigger){
		levelmanager.LoadLevel ("Win Screen");
	}
}
