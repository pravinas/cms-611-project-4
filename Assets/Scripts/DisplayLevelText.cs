using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayLevelText : MonoBehaviour {

    public Text levelText;

	// Use this for initialization
	void Start () {
        levelText.text = Statics.levelDescription;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (!Statics.levelDescription.Equals(levelText.text))
        {
            levelText.text = Statics.levelDescription;
        }
	}
}
