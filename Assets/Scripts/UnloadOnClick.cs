using UnityEngine;
using System.Collections;

public class UnloadOnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnMouseUp () {
		Debug.Log ("Now unloading self");
		LoadManager.UnloadSelf ();
	}
}
