using UnityEngine;
using System.Collections;

public class AlternatingForceController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int counter = 0;
    private bool reversed = false;
    // Use this for initialization
    void Start()
    {
        speed = 10f;
        rb = Statics.PlayerBall.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // FixedUpdate is called before performing 
    // physics calculations.
    void FixedUpdate()
    {
        counter += 1;

        if (counter % 120 == 0) {
            if (reversed) {
                reversed = false;
            } else {
                reversed = true;
            }
        }
         
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (reversed) {
            moveHorizontal *= -1;
            moveVertical *= -1;
        }

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }
}
