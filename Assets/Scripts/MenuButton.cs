using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {
	public string levelName;
	// Update is called once per frame
	void Start () {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Confined;
	}
	public void LoadLevelNow (string x){
		SceneManager.LoadScene(x);
}
}
