using UnityEngine;
using System.Collections;

public class LoadControlScene : MonoBehaviour {
	public string levelName;
	// Use this for initialization
	void Start () {
		Application.LoadLevelAdditive (levelName);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
