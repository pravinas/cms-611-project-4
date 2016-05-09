using UnityEngine;
using System.Collections;

public class MusicLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (GameObject.FindGameObjectsWithTag("Music").Length == 0) {
			GameObject musicSource = Resources.Load<GameObject>("BkgMusicSource");
			GameObject.Instantiate (musicSource);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
