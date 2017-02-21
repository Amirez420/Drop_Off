using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Quit () {
		Debug.Log ("works!");
		Application.Quit ();
	
	}
}
