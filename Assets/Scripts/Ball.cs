using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public bool isPreparing = true;
	public float velocity;
	public Rigidbody2D rb;

	// Use this for initialization
	void Awake () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") && isPreparing) {
			isPreparing = false;
			transform.parent = null;
			rb.AddForce (new Vector2(velocity, velocity));
		}
	}
}
