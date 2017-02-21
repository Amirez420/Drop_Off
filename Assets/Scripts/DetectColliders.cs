using UnityEngine;
using System.Collections;

public class DetectColliders : MonoBehaviour {
	public GameObject player;
	public GameObject firstPersonController;
	private IsFlipped isFlippedScript;
	private rotate gravityRotate;
	private bool isFlipped;

	//make more bools
	public bool flipYPos;
	public bool flipYNeg;
	public bool flipZPos;
	public bool flipZNeg;
	public bool flipXPos;
	public bool flipXNeg;


	void Start () {
		gravityRotate = player.GetComponent<rotate> ();
		isFlippedScript = player.GetComponent<IsFlipped> ();
	}
	
	void OnTriggerEnter (Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			isFlippedScript.isUpsideDown = !isFlippedScript.isUpsideDown;

			player.transform.position = new Vector3 (firstPersonController.transform.position.x,firstPersonController.transform.position.y,firstPersonController.transform.position.z);
			firstPersonController.transform.position = new Vector3 (player.transform.position.x,player.transform.position.y,player.transform.position.z);
			//make more if statements
			if (flipYPos) {
				gravityRotate.FlipPlayer (new Vector3(0,9.81f,0),new Vector3(0,0,180));
			} else if (flipYNeg) {
				gravityRotate.FlipPlayer (new Vector3(0,-9.81f,0),new Vector3(0,0,0));
			}
			if (flipZPos) {
				gravityRotate.FlipPlayer (new Vector3(0,0,9.81f),new Vector3(-90,0,0));
			} else if (flipZNeg) {
				gravityRotate.FlipPlayer (new Vector3(0,0,-9.81f),new Vector3(90,0,0));
			}
			if (flipXPos) {
				gravityRotate.FlipPlayer (new Vector3(9.81f,0,0),new Vector3(0,0,90));
			} else if (flipXNeg) {
				gravityRotate.FlipPlayer (new Vector3(-9.81f,0,0),new Vector3(0,0,-90));
			}

		}
	}
}