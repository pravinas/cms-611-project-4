﻿using UnityEngine;
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
        Statics.levelDescription = "A whole new world";
    }

	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
			player.transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime);
            rb.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
			player.transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime);
            rb.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
			//rb.position = new Vector3(0, 0, rb.position.z + (transform.forward * speed * Time.deltaTime).z);
			//rb.velocity = camera.transform.forward * speed;
			//rb.transform.position += rb.transform.forward * speed * Time.deltaTime;
			rb.velocity += camera.transform.forward * speed * Time.deltaTime;

			//rb.AddForce (-camera.transform.forward * speed);
		}

		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
			//rb.position = new Vector3(0, 0, rb.position.z + (transform.forward * speed * Time.deltaTime).z);
			//rb.velocity = - camera.transform.forward * speed;
			//rb.transform.position -= rb.transform.forward * speed * Time.deltaTime;
			rb.velocity -= camera.transform.forward * speed * Time.deltaTime;

			//rb.AddForce (camera.transform.forward * speed);
		}
		if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)) {
			rb.velocity = new Vector3 (0, 0, 0);
		}
		if (!(Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.S))) {
			rb.velocity = new Vector3 (0, rb.velocity.y, 0);
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
