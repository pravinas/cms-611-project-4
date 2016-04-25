using UnityEngine;
using System.Collections;

// Declares static variables for objects
public class Statics : MonoBehaviour {

	// All Static Objects
	static public GameObject board;
	static public GameObject PlayerBall;
	static public GameObject mainCamera;


	public GameObject boardRef;
	public GameObject PlayerBallRef;
	public GameObject cameraRef;

	// Use this for initialization
	void Start () {
		board = boardRef;
		PlayerBall = PlayerBallRef;
		mainCamera = cameraRef;
	}
}
