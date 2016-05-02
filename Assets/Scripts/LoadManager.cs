using UnityEngine;
using System.Collections;

public class LoadManager : MonoBehaviour {

	private static string childScene;
	private static string selfScene;

	// Use this for initialization
	void Start () {
		if (PauseManager.getPauseType () == "gamePause") {
			selfScene = "UIScreenOverlay";
			childScene = "UIPauseButtons";
		} else if (PauseManager.getPauseType() == "levelEnd")
        {
            selfScene = "UIScreenOverlay";
            childScene = "UILevelCompleteButtons";
        }
		Debug.Log ("PAUSE TYPE: " + PauseManager.getPauseType ());
		Application.LoadLevelAdditive (childScene);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void UnloadSelf() {
		Debug.Log ("load manager called to unload child - " + childScene + ", self - " + selfScene);
		Application.UnloadLevel (childScene);
		Application.UnloadLevel (selfScene);
	}
}
