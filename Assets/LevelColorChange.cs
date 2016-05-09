﻿using UnityEngine;
using System.Collections;

public class LevelColorChange : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Material colorMaterial = (Material)Resources.Load ("Material.002", typeof(Material));
		//colorMaterial.SetColor ("_EmissionColor",new Color(0.35f,0.59f,1.0f));

		//colorMaterial.SetColor( "_Color",new Color(174.0f/255.0f,1.0f,1.0f));
		Debug.Log("Setting Board Color");
		if (Statics.currentLevel != null) {
			Debug.Log (Statics.levelColors[0]);
			colorMaterial.SetColor ("_EmissionColor", Statics.levelColors [Statics.currentLevel]);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}