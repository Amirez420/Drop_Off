using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Ontrigerr : MonoBehaviour {

	public GameObject judiObject;
	private GravNrotate judi;
	public float gravity;
	private Vector3 originalGravity;

	// Use this for initialization
	void Start () 
	{
		originalGravity = Physics.gravity;
		//judi = judiObject.GetComponent<GravNrotate>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider Other) 
	{
		if (Other.tag == "Player") 
		{
			print ("isCollided");
			Physics.gravity = new Vector3 (0, gravity, 0);
			judiObject.transform.rotation = Quaternion.Euler (0, 0, 0);
				//new Quaternion (180f, 0, 0, 0);
			//judi.GravityFlip();
		}
	}

	void OnTriggerExit (Collider collider){
		if (collider.tag == "Player") {
			Physics.gravity = originalGravity;
			//judi.GravityUnFlip();
		}
	}

}

