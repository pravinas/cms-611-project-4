using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour {

    public float springAmount;

	// Use this for initialization
	void Start () {
        springAmount = 500f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    
	}

    void OnCollisionEnter(Collision collision) {
        Rigidbody playerRB = collision.gameObject.GetComponent<Rigidbody>();

        Vector3 movement = new Vector3(0, springAmount, 0);

        playerRB.AddForce(movement);
    }
}
