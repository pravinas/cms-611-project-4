using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

    public float moveDistance;
    public int delay;
    public float time;
	// Use this for initialization
	void Start () {
        moveDistance = 3.875f;
        delay = 120;
        time = 0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (delay == 0)
        {
            time += 1f;
            transform.position = new Vector3(transform.position.x, ((Mathf.PingPong(time/60, moveDistance) * (6f/3.875f)) - 8.5f), (Mathf.PingPong(time/60f, moveDistance) - (moveDistance/2f)) * 16f);

            if (delay == 0)
            {
                if (transform.position.z == -31f)
                {
                    delay = 120;
                } else if (transform.position.z > 30.8f)
                {
                    delay = 60;
                }
            }
        }
        else
        {
            delay -= 1;
        }
    }
}
