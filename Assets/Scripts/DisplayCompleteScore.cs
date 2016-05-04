using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayCompleteScore : MonoBehaviour {

    public Text score;

	// Use this for initialization
	void Start () {
        score.text = Statics.timeElapsed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
