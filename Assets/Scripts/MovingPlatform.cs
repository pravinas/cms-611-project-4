using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

    public float moveDistance;
    public int delay;
    public float time;
	// Use this for initialization
	void Start () {
        moveDistance = 4f;
        delay = 120;
        time = 0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (delay == 0)
        {
            time += 1f;
            transform.position = new Vector3(transform.position.x, ((Mathf.PingPong(time/60, 8) - 4)) * 1.5f, (Mathf.PingPong(time/60, moveDistance * 2f) - 4f) * 8f);

            if ((transform.position.z == -32f || transform.position.z == 32f) && delay == 0)
            {
                delay = 120;
            }
        }
        else
        {
            delay -= 1;
        }
    }
}
