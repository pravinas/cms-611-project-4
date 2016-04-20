using UnityEngine;
using System.Collections;

public class FPSControls1 : MonoBehaviour {

	public float speed;
	public float turnSpeed;

	private Rigidbody rb;
	public GameObject player;
    public GameObject camera;

	// Use this for initialization
	void Start () {
		speed = 10f;
		turnSpeed = 200f;
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
			rb.transform.position += camera.transform.forward * speed * Time.deltaTime;
			//rb.AddForce (-camera.transform.forward * speed);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			//rb.position = new Vector3(0, 0, rb.position.z + (transform.forward * speed * Time.deltaTime).z);
			//rb.velocity = - camera.transform.forward * speed;
			rb.transform.position -= camera.transform.forward * speed * Time.deltaTime;
			//rb.AddForce (camera.transform.forward * speed);
		}

		Debug.Log ("rb.vel: " + rb.velocity); //Debug
			
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
