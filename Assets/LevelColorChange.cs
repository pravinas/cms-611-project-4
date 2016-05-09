using UnityEngine;
using System.Collections;

public class LevelColorChange : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Material colorMaterial = (Material)Resources.Load ("Material.002", typeof(Material));

		colorMaterial.SetColor( "_SpecColor",Color.red);
		colorMaterial.SetColor ("_EmissionColor",Color.red);

		colorMaterial.color = Color.red;
		//Renderer renderers = GetComponent<Renderer> ();
		//renderers.materials[3] = colorMaterial;
		//renderers.materials [3].color = Color.red;
		/*for (int i = 0; i < renderers.materials.Length; i++) {
			renderers.materials [i].color = Color.red;
		}*/

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
