using UnityEngine;
using System.Collections;

public class waterExit : MonoBehaviour {
	public GameObject water;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void OnTriggerExit (Collider other) {
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "MainCamera")
		{
			water.SetActive (false);

		}
	}
}
