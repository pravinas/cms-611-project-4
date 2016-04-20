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
		turnSpeed = 50f;
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
	}

	// FixedUpdate is called before performing 
	// physics calculations.
	void FixedUpdate () {
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (0, 0, moveVertical);

        Debug.Log("moveVertical: " + moveVertical);

        rb.velocity = movement * speed;
        

        //player.transform.position = camera.transform.forward * speed * Time.deltaTime;

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, camera.transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
