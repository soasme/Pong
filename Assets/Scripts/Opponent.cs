using UnityEngine;
using System.Collections;

public class Opponent : MonoBehaviour {

	public float speed = 10;
	public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		Vector2 thisPos = gameObject.transform.position;
//		Vector2 pos = new Vector2 (ball.transform.position.x, thisPos.y);
//		gameObject.transform.position = pos;
		ball = GameObject.FindGameObjectWithTag("ball");
		if (ball != null) {
			Vector2 targetPos = Vector2.Lerp (gameObject.transform.position, ball.transform.position, Time.deltaTime * speed);
			Vector2 originPos = gameObject.transform.position;
			gameObject.transform.position = new Vector2 (targetPos.x, originPos.y);
		}
	}
}
