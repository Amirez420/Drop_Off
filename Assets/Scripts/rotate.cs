using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour 
{
	private float m_lerpNo = 0;
	float playerZRot;
	Vector3 m_gravity;
	Rigidbody rb;
	Vector3 m_rotation;

	void Start()
	{
		rb = GetComponentInChildren<Rigidbody> ();
	}

	public void FlipPlayer(Vector3 gravity, Vector3 rotation)
	{
		m_lerpNo = 0;
		m_rotation = rotation;
		m_gravity = gravity;
		StopAllCoroutines ();
		rb.isKinematic = true;
		StartCoroutine ("FlippingPlayer");
		Invoke ("NewGravity", 0.5f);
	}

	IEnumerator FlippingPlayer()
	{
		while (true) 
		{
			m_lerpNo += 0.01f;
			float rotationX = Mathf.Lerp (transform.eulerAngles.x, m_rotation.x, m_lerpNo);
			float rotationY = Mathf.Lerp (transform.eulerAngles.y, m_rotation.y, m_lerpNo);
			float rotationZ = Mathf.Lerp (transform.eulerAngles.z, m_rotation.z, m_lerpNo);
			transform.rotation = Quaternion.Euler(rotationX,rotationY,rotationZ);
			yield return new WaitForSeconds (0.01f);
		}
	}


	public void FlipZPos()
	{
		m_lerpNo = 0;
		transform.rotation = Quaternion.Euler(0,0,0 );
		StartCoroutine("FlippingZPos");
		//gravity = new Vector3 (0, 0, 9.81f);
		Invoke ("NewGravity", 1f);
	}

	IEnumerator FlippingZPos()
	{
		while (true) 
		{
			m_lerpNo += 0.01f;
			float rotation = Mathf.Lerp (0, -90, m_lerpNo);
			transform.rotation = Quaternion.Euler(rotation,0,0);
			yield return new WaitForSeconds (0.01f);
		}
	}

	public void FlipZNeg()
	{
		m_lerpNo = 0;
		transform.rotation = Quaternion.Euler(0,0,0 );
		StartCoroutine ("FlippingZNeg");
		//gravity = new Vector3 (0, 0, -9.81f);
		Invoke ("NewGravity", 1f);
	}

	IEnumerator FlippingZNeg()
	{
		while (m_lerpNo != 1) 
		{
			m_lerpNo += 0.01f;
			float rotation = Mathf.Lerp (0, 90, m_lerpNo);
			transform.rotation = Quaternion.Euler(rotation,0,0);
			yield return new WaitForSeconds (0.01f);
		}
	}

	public void FlipXPos()
	{
		m_lerpNo = 0;
		transform.rotation = Quaternion.Euler(0,0,0 );
		StartCoroutine ("FlippingXPos");
		//gravity = new Vector3 (9.81f, 0, 0);
		Invoke ("NewGravity", 1f);
	}

	IEnumerator FlippingXPos()
	{
		while (m_lerpNo != 1) 
		{
			m_lerpNo += 0.01f;
			float rotation = Mathf.Lerp (0, 90, m_lerpNo);
			transform.rotation = Quaternion.Euler(0,0,rotation);
			yield return new WaitForSeconds (0.01f);
		}
	}

	public void FlipXNeg()
	{
		transform.rotation = Quaternion.Euler(0,0,0 );
		StartCoroutine ("FlippingXNeg");
		//gravity = new Vector3 (-9.81f, 0, 0);
		Invoke ("NewGravity", 1f);
	}

	IEnumerator FlippingXNeg()
	{
		while (m_lerpNo != 1) 
		{
			m_lerpNo += 0.01f;
			float rotation = Mathf.Lerp (0, -90, m_lerpNo);
			transform.rotation = Quaternion.Euler(0,0,rotation);
			yield return new WaitForSeconds (0.01f);
		}
	}

	public void FlipYPos()
	{
		m_lerpNo = 0;
		transform.rotation = Quaternion.Euler(0,0,0 );
		StopAllCoroutines ();
		rb.isKinematic = true;
		StartCoroutine ("FlippingYPos");
		//gravity = new Vector3 (0, 9.81f, 0);
		Invoke ("NewGravity", 1f);
		//Physics.gravity = new Vector3 (0, 9.81f, 0);
	}

	IEnumerator FlippingYPos()
	{
		while (m_lerpNo != 1) 
		{
			m_lerpNo += 0.01f;
			float rotation = Mathf.Lerp (0, 180, m_lerpNo);
			transform.rotation = Quaternion.Euler(0,0,rotation);
			yield return new WaitForSeconds (0.01f);
		}

	}

	public void FlipYNeg()
	{
		//transform.rotation = Quaternion.Euler(0,0,0);
		m_lerpNo = 0;
		playerZRot = transform.eulerAngles.z;
		print (playerZRot);

		StopAllCoroutines ();
		rb.isKinematic = true;
		StartCoroutine ("FlippingYNeg");
		//gravity = new Vector3 (0, -9.81f, 0);
		Invoke ("NewGravity", 1f);
	}

	IEnumerator FlippingYNeg()
	{
		while (m_lerpNo != 1) 
		{
			m_lerpNo += 0.01f;
			float rotation = Mathf.Lerp (playerZRot, 0, m_lerpNo);
			transform.rotation = Quaternion.Euler(0,0,rotation);
			yield return new WaitForSeconds (0.01f);
		}
	}

	void NewGravity()
	{
		Physics.gravity = m_gravity;
		rb.isKinematic = false;
	}
}