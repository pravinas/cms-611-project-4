using UnityEngine;
using System.Collections;

public class StartSpawn : MonoBehaviour {

	public GameObject ball;
	// Use this for initialization
	void Start () {
		ball.transform.position = this.transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (ball.transform.position.y <= -20)
        {
            ball.transform.position = this.transform.position;
            ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            if (Statics.levels[Statics.currentLevel].Equals("MouseTeleportControl"))
            {
                Statics.levelDescription = "... except there. No one goes outside the box.";
            } else
            {
                Statics.levelDescription = "Well that was awkward...";
            }
        }
	}
}
