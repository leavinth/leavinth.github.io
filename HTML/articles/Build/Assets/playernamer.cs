using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playernamer : MonoBehaviour {
	public string scene;
	public void OnClick(){
		SceneManager.LoadScene (scene);

	}
	void Update(){
		if (Input.GetKeyUp ("enter") || Input.GetKeyUp ("return")) {
			control.instance.score = 0;
			SceneManager.LoadScene (scene);
		}
	}
}
