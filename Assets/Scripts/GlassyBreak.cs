using UnityEngine;
using System.Collections;

public class GlassyBreak : MonoBehaviour {
	public Rigidbody[] rb;
	public MeshCollider[] mc;

	void Start () 
	{
		rb = gameObject.GetComponentsInChildren<Rigidbody>();
		mc = gameObject.GetComponentsInChildren<MeshCollider> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Break") {
			//rb [0].useGravity = true;
			//rb [1].useGravity = true;

			for (int i = 0; i < rb.Length; i++) 
			{
				rb [i].useGravity = true;
			}

			for (int y = 0; y < mc.Length; y++) {
				mc [y].enabled = true;
			}
		}
			//other.attachedRigidbody.useGravity = true;
	}
}
