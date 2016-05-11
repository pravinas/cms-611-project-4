using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HelpTextColorChange : MonoBehaviour {

	private Outline outline;
	// Use this for initialization
	void Start () {
		if (Statics.currentLevel != null && Statics.currentLevel < Statics.levels.Length) {
			outline = GetComponent<Outline> ();
			Color oColor = Statics.levelColors [Statics.currentLevel];
			outline.effectColor = new Color (oColor.r + .4f, oColor.g + .4f, oColor.b + .4f);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
