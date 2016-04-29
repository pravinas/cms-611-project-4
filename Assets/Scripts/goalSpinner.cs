using UnityEngine;
using System.Collections;

public class goalSpinner : MonoBehaviour {

	private float delay;


	// Use this for initialization
	void Start () {
		delay = 5;
	}
	
	// Update is called once per frame
	void Update () {
		
		StartCoroutine (waitAndRotate());
	}


	IEnumerator waitAndRotate() {
		int x = Random.Range(-2, 2);
		int y = Random.Range(-2, 2);
		int z = Random.Range(-2, 2);

		gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(x, y, z));
		//gameObject.transform.Rotate (new Vector3(x, y, z));

		yield return new WaitForSeconds(delay);


	}
}
