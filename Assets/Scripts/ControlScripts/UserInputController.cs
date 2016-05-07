
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UserInputController : MonoBehaviour
{
    public float speed;
    private int keyCount;
    private Rigidbody rb;
    private GameObject player;
    private List<KeyCode> inputs = new List<KeyCode>();

    // Use this for initialization
    void Start()
    {
        player = Statics.PlayerBall;
        speed = 10f;
        rb = player.GetComponent<Rigidbody>();
        keyCount = 0;
        Statics.levelDescription = "Pick your poison";
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
                if (Input.GetKeyDown(vKey) && inputs.Contains(vKey) == false) {
                    if (inputs.Count == 0) {
                        inputs.Add(vKey);
                    } else if (inputs.Count == 1) {
                        inputs.Add(vKey);
                    } else if (inputs.Count == 2 ) {
                        inputs.Add(vKey);
                    } else if (inputs.Count == 3) {
                        inputs.Add(vKey);
                    }
                    keyCount += 1;
                }
            }
        } else {
            if (Input.GetKey (inputs[0])) {
                rb.AddForce(new Vector3(0, 0, 1) * speed);
            } else if (Input.GetKey (inputs[1])) {
                rb.AddForce(new Vector3(0, 0, -1) * speed);
            }

            if (Input.GetKey (inputs[2])) {
                rb.AddForce(new Vector3(-1, 0, 0) * speed);
            } else if (Input.GetKey (inputs[3])) {
                rb.AddForce(new Vector3(1, 0, 0) * speed);
            }
        }
    }
}