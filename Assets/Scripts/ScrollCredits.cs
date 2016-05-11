using UnityEngine;
using System.Collections;

public class ScrollCredits : MonoBehaviour {
	private bool isScroll;
	public int speed = 20;

	// Use this for initialization
	void Start () {
		this.isScroll = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.isScroll) {
			Debug.Log ("scrolling!");
			transform.Translate (new Vector3 (-speed * Time.deltaTime, 0));
			Debug.Log (transform.position.x + " + " + gameObject.GetComponent<RectTransform> ().rect.width + " = " + (transform.position.x + gameObject.GetComponent<RectTransform> ().rect.width));
			if (transform.position.x < -100) {
				Debug.Log ("stop scrolling!");
				isScroll = false;
			}
		}
	}

	public void scrollLeft () {
		Debug.Log ("activated scroll");
		if (this.isScroll == false) {
			this.isScroll = true;
		} else {
			this.isScroll = false;
		}
		Debug.Log ("x before: " + transform.position.x);
		transform.position.Set (Screen.width, -575, 0);
		Debug.Log ("x before: " + transform.position.y);
		Debug.Log ("this.isScroll: " + this.isScroll);
	}
}
