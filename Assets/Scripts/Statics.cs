using UnityEngine;
using System.Collections;

// Declares static variables for objects
public class Statics : MonoBehaviour {
	public GameObject groundRef;
	public GameObject PlayerBallRef;

	static public GameObject board;
	static public GameObject PlayerBall;
	// Use this for initialization
	void Start () {
		board = groundRef;
		PlayerBall = PlayerBallRef;
	}
}
