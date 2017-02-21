using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.FirstPerson;

public class wallJump : MonoBehaviour {

	RigidbodyFirstPersonController m_FirstPersonController;

	int touchingWall = 0;

	// Use this for initialization
	void Start () {

		m_FirstPersonController = GetComponent<RigidbodyFirstPersonController> ();
		touchingWall = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (touchingWall > 0 && !m_FirstPersonController.Grounded && CrossPlatformInputManager.GetButtonDown ("Jump")) {

			Debug.Log ("Jump");
			m_FirstPersonController.WallJump ();
		}
	}

	void OnTriggerEnter(Collider collider){

		if (collider.CompareTag("Wall")) {

			touchingWall++;
		}
	}

	void OnTriggerExit(Collider collider){

		if (collider.CompareTag("Wall")) {

			touchingWall--;
		}
	}
}
