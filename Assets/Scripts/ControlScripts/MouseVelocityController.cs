
using UnityEngine;
using System.Collections;

public class MouseVelocityController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        speed = 10f;
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

            rb.velocity = movement * speed;
        }
    }
}