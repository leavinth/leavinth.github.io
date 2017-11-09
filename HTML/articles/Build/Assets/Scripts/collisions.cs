using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisions : MonoBehaviour {
	public string scene;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision2D col){
		if(col.gameObject.tag == "Insta-kill")
		{
			control.instance.tim = Time.timeSinceLevelLoad;
			SceneManager.LoadScene (scene);
		}
	}
	void OnTriggerEnter2D(Collider2D col2){
		if (col2.gameObject.tag == "coin") {
			control.instance.score += 1; 
			DestroyObject (col2.gameObject);
		}
		if (col2.gameObject.tag == "wingame") {
			control.instance.score += 5;
			control.instance.win = true;
			control.instance.tim = Time.timeSinceLevelLoad;
			SceneManager.LoadScene (scene);
		}
	}
}
