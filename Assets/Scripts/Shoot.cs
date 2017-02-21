using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public Rigidbody ruby;

	public Transform spawn;

	public GameObject prefab;

	private float thrust = 200;

	// Use this for initialization
	void Start () {
		ruby = prefab.GetComponent<Rigidbody> ();
	}


	void FixedUpdate(){
		if (Input.GetKeyDown(KeyCode.E)) {
			ruby.AddForce (transform.forward * thrust);
			Instantiate (prefab, spawn.position, spawn.rotation);
		}
	}
}
