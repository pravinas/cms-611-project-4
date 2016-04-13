using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);
			transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
		}
	}
}
