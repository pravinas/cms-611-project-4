using UnityEngine;
using System.Collections;

public class LoadSceneOnClick : MonoBehaviour {

	public string levelName;

	// Use this for initialization
	void OnMouseUp () {
		Debug.Log ("Now loading: " + levelName);
		Application.LoadLevel (levelName);
	}
}
