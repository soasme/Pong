using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public TextMesh mesh;
	public GameObject table;
	public GameObject ballPref;
	public int score;

	GameObject ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ball = GameObject.FindGameObjectWithTag ("ball");
		mesh.text = "" + score;
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log (other);
		if (other.gameObject.name == "ball") {
			Destroy (ball);
			score += 1;
			GameObject b = Instantiate (ballPref, new Vector2 (0, 1.14f), Quaternion.identity) as GameObject;
			b.name = "ball";
		}
	}
}
