using UnityEngine;
using System.Collections;

public class waterTrigger : MonoBehaviour {
	public GameObject water;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "MainCamera") {
			water.SetActive (true);
			GetComponent<AudioSource> ().Play ();
		}
	}
		// Update is called once per frame
		void OnTriggerExit (Collider other) {
			if (other.gameObject.tag == "Player" || other.gameObject.tag == "MainCamera")
			{
				water.SetActive (false);
			GetComponent<AudioSource> ().Stop ();
			}
		}
	}


