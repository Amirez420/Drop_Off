using UnityEngine;
using System.Collections;

public class EscapeExit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Debug.Log ("Werks yo");
			Application.Quit();
	}
}
}
