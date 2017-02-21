using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Respawn : MonoBehaviour 
{
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "MainCamera") 
		{
			SceneManager.LoadScene (1);
		}
	}
}
