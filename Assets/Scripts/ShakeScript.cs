using UnityEngine;
using System.Collections;

public class ShakeScript : MonoBehaviour {
	public float shakeSpeed = 0.02f;
	public float fallSpeed = 1f;
	void Start () 
	{
	
	}

	void FixedUpdate () 
	{
		float posY = transform.position.y - fallSpeed * Time.deltaTime;
		float posX = transform.position.x + shakeSpeed;
		float posZ = transform.position.z + shakeSpeed;
		shakeSpeed *= -1;

		transform.position = new Vector3 (posX, posY, posZ);
	}
}
