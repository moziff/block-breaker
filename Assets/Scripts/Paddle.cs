using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float paddleSpeed = 1f;


	private Vector3 playerPos = new Vector3 (0, .5f, 0);

	void Update () 
	{
		float xPos = Input.mousePosition.x / Screen.width * 16;
		playerPos = new Vector3 (Mathf.Clamp (xPos, 0f, 15f), .5f, 0f);
		transform.position = playerPos;

	}
}