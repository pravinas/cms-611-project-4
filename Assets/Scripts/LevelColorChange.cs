using UnityEngine;
using System.Collections;

public class LevelColorChange : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Material colorMaterial = (Material)Resources.Load ("Material.002", typeof(Material));

		if (Statics.currentLevel != null && Statics.currentLevel < Statics.levels.Length) {
			colorMaterial.SetColor ("_EmissionColor", Statics.levelColors [Statics.currentLevel]);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
