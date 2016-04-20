using UnityEngine;
using System.Collections;

public class LevelButton : MonoBehaviour {

	public string level;

	public void loadLevel(){
		Application.LoadLevel (level);
	}
}
