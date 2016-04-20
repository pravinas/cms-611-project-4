using UnityEngine;
using System.Collections;

public class FPSCamera : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	public float turnSpeed = 50f;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}

	void Update() {
	
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime);
		}
	
	}

	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
