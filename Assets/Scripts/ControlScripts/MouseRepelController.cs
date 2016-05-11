using UnityEngine;
using System.Collections;

public class MouseRepelController : MonoBehaviour
{
    private Rigidbody rb;
    private GameObject player;
	public Camera thisCamera;

    // Use this for initialization
    void Start()
    {
		player = Statics.PlayerBall;
        rb = player.GetComponent<Rigidbody>();
        Statics.levelDescription = "Rodent repellent";
    }

    // Update is called once per frame
    void Update()
    {

    }

    // FixedUpdate is called before performing 
    // physics calculations.
    void FixedUpdate() {
        if (Input.GetMouseButton(0)) {
            var mousePos = Input.mousePosition;
            mousePos = thisCamera.ScreenToWorldPoint(mousePos);

            var moveBy = mousePos - player.transform.position;
            moveBy.y = 0;

            rb.velocity = new Vector3(0, 0, 0);
            rb.velocity = moveBy * -1;
        }
    }
}