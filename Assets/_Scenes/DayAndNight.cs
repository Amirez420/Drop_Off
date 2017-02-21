using UnityEngine;
using System.Collections;

public class DayAndNight : MonoBehaviour {
	private float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		speed = 20 * Time.deltaTime;

		transform.Rotate(Vector3.up * speed);

	}
}
