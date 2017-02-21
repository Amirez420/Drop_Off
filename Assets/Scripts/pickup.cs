using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour 
{
	public timer timerObject;
	public Animator animate;
	// Use this for initialization
	void Start () 
	{
		animate.enabled = false;
	}


	public bool clicked = false;

	void OnTriggerStay(Collider other)
	{
		if ((Input.GetKeyDown(KeyCode.R)&&(other.gameObject.tag == "Player" || other.gameObject.tag == "MainCamera"))&&(!clicked))
		{
			timerObject.AddTime (10);
			animate.enabled = true;
			GetComponent<AudioSource> ().Play ();
			clicked = true;
			Destroy (gameObject, 2f);
		}
	}

	void OnTriggerExit()
	{
		clicked = false;
	}
}
