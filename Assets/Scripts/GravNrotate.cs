using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class GravNrotate : MonoBehaviour 
{

	public Rigidbody rb;
	public bool flipped = false;
	public bool flippy = false;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		if (flipped) {
			//rb.AddForce (-Physics.gravity, ForceMode.Acceleration);
			//Physics.gravity = new Vector3 (0, -9.8f, 0);
			flipped = false;
			//flippy = true;
		} else {
			//rb.AddForce (Physics.gravity, ForceMode.Acceleration);
		}
//		if(flippy){
//			rb.AddForce (Physics.gravity, ForceMode.Acceleration);
//		}
	}

	public void GravityFlip()
	{
		flipped = true;
		print ("Gottem");
		Physics.gravity = new Vector3 (0, 9.8f, 0);
		//transform.rotation = Quaternion.Euler (0, 0, 180);
	}

	public void GravityUnFlip(){
		//flippy = false;
		flipped = false;
		//transform.rotation = Quaternion.Euler(0,0,0);
	}
}
