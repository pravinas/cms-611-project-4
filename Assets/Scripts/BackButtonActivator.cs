using UnityEngine;
using System.Collections;

public class BackButtonActivator : MonoBehaviour {

	public string selfScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void backToMainMenu() {
		Application.UnloadLevel (selfScene);
		Application.LoadLevelAdditive ("UIMenu");
	}
}
