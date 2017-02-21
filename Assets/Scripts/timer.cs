using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public Text timerText;
	public float myCoolTimer = 30;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		myCoolTimer -= Time.deltaTime;
		//timerText.text = myCoolTimer.ToString("f0");
		timerText.text = string.Format ("Timer: {0}", Mathf.FloorToInt(myCoolTimer) + 1);
		print (myCoolTimer);
	}

	public void AddTime(float time)
	{
		myCoolTimer += time;
	}
}
