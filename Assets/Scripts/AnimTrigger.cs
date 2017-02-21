using UnityEngine;
using System.Collections;

public class AnimTrigger : MonoBehaviour {
	public Animator ani;

	// Use this for initialization
	void Start () {
		ani.enabled = false;
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		ani.enabled = true;
		
	
	}
}
