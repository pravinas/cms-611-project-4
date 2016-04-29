using UnityEngine;
using System.Collections;

public class PauseManager : MonoBehaviour {

	private static string pauseType;

	// Use this for initialization

    public void buttonPause()
    {
        setPauseType("gamePause");
        pauseTime();
    }

	public static void setPauseType(string type) {
		pauseType = type;
	}

    public void pauseTime()
    {
        Time.timeScale = 0.0f;
    }

    public void resumeTime()
    {
        Debug.Log("Hello");
        Time.timeScale = 1.0f;
    }

	public static string getPauseType() {
		return pauseType;
	}
}
