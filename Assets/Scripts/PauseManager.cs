using UnityEngine;
using System.Collections;

public class PauseManager : MonoBehaviour {

	private static string pauseType;

	// Use this for initialization
	void Start () {
		pauseType = "gamePause";
	}
	
	public static void setPauseType(string type) {
		pauseType = type;
	}

	public static string getPauseType() {
		return pauseType;
	}
}
