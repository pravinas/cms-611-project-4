using UnityEngine;
using System.Collections;

public class MouseTeleportController : MonoBehaviour {

    private GameObject player;

    // Use this for initialization
    void Start () {
		player = Statics.PlayerBall;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate () {
        if (Input.GetMouseButtonDown(0)) {
            var mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.y = player.transform.position.y;

            player.transform.position = mousePos;
        }
    }
}
