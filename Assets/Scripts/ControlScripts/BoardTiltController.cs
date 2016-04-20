using UnityEngine;
using System.Collections;

// TODO: Change to board tilt implementation to only rotate the board and not add velocity.
public class BoardTiltController : MonoBehaviour {
	public float speed;
	private Rigidbody boardRigidbody;
	// Use this for initialization
	void Start () {
		boardRigidbody = Statics.board.GetComponent<Rigidbody> ();
		boardRigidbody.freezeRotation = false;
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

		Vector3 movement = new Vector3 (moveVertical, 0, moveHorizontal);

		boardRigidbody.angularVelocity = movement * speed;
	}
}
