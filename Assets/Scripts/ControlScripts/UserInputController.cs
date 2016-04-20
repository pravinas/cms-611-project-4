
using UnityEngine;
using System.Collections;

public class UserInputController : MonoBehaviour
{
    public float speed;
    private int keyCount;
    private Rigidbody rb;
    private GameObject player;
    private KeyCode up;
    private KeyCode down;
    private KeyCode left;
    private KeyCode right;


    // Use this for initialization
    void Start()
    {
        player = Statics.PlayerBall;
        speed = 100f;
        rb = player.GetComponent<Rigidbody>();
        keyCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // FixedUpdate is called before performing 
    // physics calculations.
    void FixedUpdate() {
        if (keyCount < 4) {
            foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))) {
                if (Input.GetKeyDown (vKey)) {
                    if (keyCount == 0) {
                        up = vKey;
                    } else if (keyCount == 1) {
                        down = vKey;
                    } else if (keyCount == 2) {
                        left = vKey;
                    } else if (keyCount == 3) {
                        right = vKey;
                    }
                    keyCount += 1;
                }
            }
        } else {
            if (Input.GetKey (up)) {
                rb.AddForce(new Vector3(0, 0, 1) * speed);
            } else if (Input.GetKey (down)) {
                rb.AddForce(new Vector3(0, 0, -1) * speed);
            }

            if (Input.GetKey (left)) {
                rb.AddForce(new Vector3(-1, 0, 0) * speed);
            }
            else if (Input.GetKey (right)) {
                rb.AddForce(new Vector3(1, 0, 0) * speed);
            }
        }
    }
}