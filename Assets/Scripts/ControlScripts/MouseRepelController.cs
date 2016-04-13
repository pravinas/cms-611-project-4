
using UnityEngine;
using System.Collections;

public class MouseRepelController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // FixedUpdate is called before performing 
    // physics calculations.
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            var mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.y = 0;

            rb.velocity = mousePos * -1;
        }
    }
}