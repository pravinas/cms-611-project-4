﻿using UnityEngine;
using System.Collections;

public class ForceController : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
        speed = 10f;
		rb = Statics.PlayerBall.GetComponent<Rigidbody> ();
        Statics.levelDescription = "May the force be with you";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// FixedUpdate is called before performing 
	// physics calculations.
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rb.AddForce (movement * speed);
	}
}
