﻿using UnityEngine;
using System.Collections;

public class StartLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Application.LoadLevel("BaseScene");
        Application.LoadLevelAdditive("UIMenu");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
