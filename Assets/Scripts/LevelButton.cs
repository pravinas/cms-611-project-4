using UnityEngine;
using System.Collections;

public class LevelButton : MonoBehaviour {

	public string level;
	private string baseScene = "BaseScene";

	public void loadLevel(){
		Application.LoadLevel (baseScene);
		Application.LoadLevelAdditive (level);
	}
}
