using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	private static string levelSceneName;

	// Use this for initialization
	void Start () {
	
	}
	
	public static void setLevelSceneName(string name) {
		levelSceneName = name;
	}

	public static string getLevelSceneName() {
		return levelSceneName;
	}
}
