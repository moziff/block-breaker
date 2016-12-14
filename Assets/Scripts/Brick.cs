using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHit;
//	private AudioSource audio;
	private int hits;
	private ScoreKeeper sk;
	public GameObject smoke;

	// Use this for initialization
	void Start () {
		hits = 0;
//		maxHit=1;
		sk= GameObject.FindObjectOfType<ScoreKeeper>();
//		audio = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		if (hits>=maxHit){
			Destroy (gameObject);
			GameObject smokepuff= Instantiate (smoke, transform.position, Quaternion.identity) as GameObject;
			smokepuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
		}


	}

	void OnCollisionEnter2D(Collision2D collision){
//		audio.Play();
		hits += 1;
		sk.IncrementScore ();
	}
}
