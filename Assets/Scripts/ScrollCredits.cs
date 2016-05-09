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
			transform.Translate (new Vector3 (-speed * Time.deltaTime, 0));
			if (transform.position.x < -7300) {
				isScroll = false;
			}
		}
	}

	public void scrollLeft () {
		transform.position.Set (7300, -575, 0);
		this.isScroll = true;
	}
}
