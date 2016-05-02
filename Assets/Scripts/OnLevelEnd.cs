using UnityEngine;
using System.Collections;

public class OnLevelEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collision)
	{
		//TODO: Implement what happens on the end of the level
		Debug.Log("Goal Reached");
		PauseManager.setPauseType ("levelEnd");
		Application.LoadLevelAdditive ("UIScreenOverlay");
	}
}
