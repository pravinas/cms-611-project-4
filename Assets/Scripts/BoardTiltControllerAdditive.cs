using UnityEngine;
using System.Collections;

public class BoardTiltControllerAdditive : MonoBehaviour {
	public float speed;
	public static GameObject board;
	private Rigidbody boardRigidbody;
	// Use this for initialization
	void Start () {
		boardRigidbody = Statics.board.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

	}
	// FixedUpdate is called before performing 
	// physics calculations.
	void FixedUpdate () {
		// Get keyboard input
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		boardRigidbody.angularVelocity = movement * speed;
	}
}
