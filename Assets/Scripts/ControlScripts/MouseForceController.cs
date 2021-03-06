﻿
using UnityEngine;
using System.Collections;

public class MouseForceController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private GameObject player;

    // Use this for initialization
    void Start()
    {
		player = Statics.PlayerBall;
        speed = 100f;
        rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // FixedUpdate is called before performing 
    // physics calculations.
    void FixedUpdate() {
        if (Input.GetMouseButton(0)) {
            float moveHorizontal = Input.GetAxis("Mouse X");
            float moveVertical = Input.GetAxis("Mouse Y");

            Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

            rb.AddForce(movement * speed);
        } 
    }
}