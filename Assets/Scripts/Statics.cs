using UnityEngine;
using System.Collections;

// Declares static variables for objects
public class Statics : MonoBehaviour {

	// All Static Objects
	static public GameObject board;
	static public GameObject PlayerBall;
	static public GameObject mainCamera;
	// TODO: Move this to its own file
	static public string[] levels;
	static public int currentLevel;
	static public int latestUnlockedLevel;

	public GameObject boardRef;
	public GameObject PlayerBallRef;
	public GameObject cameraRef;

	// Use this for initialization
	void Start () {
		board = boardRef;
		PlayerBall = PlayerBallRef;
		mainCamera = cameraRef;
		// TODO: Update this to be accurate - Handle what happens when reach max levels
		levels = new string[7];
		levels[0] ="VelocityControl";
		levels[1] = "ForceControl";
		levels[2] = "MouseAttractControl";
		levels[3] = "MouseRepelControl";
		levels[4] = "MouseTeleportControl";
		levels[5] = "ReversedForceControl";
		levels[6] = "BoardTiltControl";
	}
}
