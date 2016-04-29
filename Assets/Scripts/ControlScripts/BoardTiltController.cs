using UnityEngine;
using System.Collections;

public class BoardTiltController : MonoBehaviour {
	public float speed;
	private GameObject board;
	// Use this for initialization
	void Start () {
		board = Statics.board;
		speed = 10;
		//boardRigidbody = Statics.board.GetComponent<Rigidbody> ();
		//boardRigidbody.freezeRotation = false;
	}

	// Update is called once per frame
	void Update () {

	}
	// FixedUpdate is called before performing 
	// physics calculations.
	void FixedUpdate () {
		// Get keyboard input
	
		Transform boardTransform = board.transform;
		if (Input.GetKey("left"))
			boardTransform.Rotate(Vector3.forward *speed * Time.deltaTime, Space.World);

		if (Input.GetKey("right"))
			boardTransform.Rotate(-Vector3.forward * speed * Time.deltaTime, Space.World);

		if (Input.GetKey("down"))
			boardTransform.Rotate(Vector3.left * speed * Time.deltaTime,Space.World);

		if (Input.GetKey("up"))
			boardTransform.Rotate(Vector3.right * speed * Time.deltaTime, Space.World);
	}
}
