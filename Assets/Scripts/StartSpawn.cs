using UnityEngine;
using System.Collections;

public class StartSpawn : MonoBehaviour {

	public GameObject ball;
	// Use this for initialization
	void Start () {
		ball.transform.position = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
