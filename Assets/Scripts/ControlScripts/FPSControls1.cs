using UnityEngine;
using System.Collections;

public class FPSControls1 : MonoBehaviour {

	public float speed;
	public float turnSpeed;

	public GameObject camera;

	private Rigidbody rb;
	private GameObject player;

	// Use this for initialization
	void Start () {
		speed = 10f;
		turnSpeed = 200f;
		player = Statics.PlayerBall;

		rb = player.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			player.transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime);
            rb.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

		if (Input.GetKey (KeyCode.RightArrow)) {
			player.transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime);
            rb.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

		if (Input.GetKey (KeyCode.UpArrow)) {
			//rb.position = new Vector3(0, 0, rb.position.z + (transform.forward * speed * Time.deltaTime).z);
			//rb.velocity = camera.transform.forward * speed;
			//rb.transform.position += rb.transform.forward * speed * Time.deltaTime;
			rb.velocity += camera.transform.forward * speed * Time.deltaTime;

			Debug.Log ("camera: " + camera.transform.forward);
			Debug.Log ("self rb: " + rb.transform.forward);
			Debug.Log ("self player: " + player.transform.forward);
			//rb.AddForce (-camera.transform.forward * speed);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			//rb.position = new Vector3(0, 0, rb.position.z + (transform.forward * speed * Time.deltaTime).z);
			//rb.velocity = - camera.transform.forward * speed;
			//rb.transform.position -= rb.transform.forward * speed * Time.deltaTime;
			rb.velocity -= camera.transform.forward * speed * Time.deltaTime;
			Debug.Log ("camera: " + camera.transform.forward);
			Debug.Log ("self rb: " + rb.transform.forward);
			Debug.Log ("self player: " + player.transform.forward);
			//rb.AddForce (camera.transform.forward * speed);
		}
		if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.UpArrow)) {
			rb.velocity = new Vector3 (0, 0, 0);
		}
	}

	// FixedUpdate is called before performing 
	// physics calculations.
			/*
	void Update () {
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveVertical * Mathf.Cos(rb.transform.eulerAngles.y), 0, moveVertical * Mathf.Sin(rb.transform.eulerAngles.y));

		//Debug.Log("angle y: " + Mathf.Cos(rb.transform.eulerAngles.y));

        //rb.velocity = movement * speed;
		if (moveVertical != 0) {
			rb.velocity = transform.forward * speed * Time.deltaTime;
		}

		Debug.Log ("rb.velocity: " + rb.velocity);

        //transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, camera.transform.localEulerAngles.y, transform.localEulerAngles.z);
    }*/
}
