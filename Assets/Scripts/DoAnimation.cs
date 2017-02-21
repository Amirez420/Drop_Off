using UnityEngine;
using System.Collections;

public class DoAnimation : MonoBehaviour {
	public Animator buildingAnimator;
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		buildingAnimator.SetTrigger ("RaiseBuilding");
	}
}
