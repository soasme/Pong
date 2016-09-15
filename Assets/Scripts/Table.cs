using UnityEngine;
using System.Collections;

public class Table : MonoBehaviour {

	public bool isMoving = false;
	public bool isLeft = false;
	public float speed = 3f;

	public float paddleSpeed = 0.1f;
	public Vector3 position;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){
		Vector2 nextPos = gameObject.transform.position;
		nextPos.x = nextPos.x + Input.GetAxis ("Horizontal") * paddleSpeed;
		nextPos.x = Mathf.Clamp (nextPos.x, -7.5f, 7.5f);
		gameObject.transform.position = nextPos;
	}

}
