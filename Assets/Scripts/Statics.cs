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
	static public Color[] levelColors;
	static public int currentLevel;
	static public int latestUnlockedLevel;

	public GameObject boardRef;
	public GameObject PlayerBallRef;
	public GameObject cameraRef;

    static public string timeElapsed;
    static public string levelDescription;

	// Use this for initialization
	void Start () {
		board = boardRef;
		PlayerBall = PlayerBallRef;
		mainCamera = cameraRef;
		//currentLevel = 0;
		// TODO: Update this to be accurate - Handle what happens when reach max levels
		levels = new string[11];
		levelColors = new Color[11];
		levels[0] = "ForceControl";
		levels[1] = "VelocityControl";
		levels[2] = "MouseAttractControl";
		levels[3] = "MouseRepelControl";
		levels[4] = "MouseTeleportControl";
		levels[5] = "ReversedForceControl";
		levels[6] = "AlternatingForceControl";
        levels[7] = "DelayForceControl";
        levels[8] = "UserInputControl";
        levels[9] = "BuddyRepelControl";
        levels[10] = "FPSControl1";

		levelColors [0] = new Color (0.35f, 0.59f, 1.0f);
		levelColors [1] = Color.blue;
		levelColors [2] = Color.green;
		levelColors [3] = Color.magenta;
		levelColors [4] = Color.red;
		levelColors [5] = Color.yellow;
		levelColors [6] = new Color (0.35f, 0.59f, 1.0f);
		levelColors [7] = Color.blue;
		levelColors [8] = Color.green;
		levelColors [9] = Color.magenta;
		levelColors [10] = Color.red;


    }
}
