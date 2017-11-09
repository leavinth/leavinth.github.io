using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class onreleasescene : MonoBehaviour {
	const string privateCode = "A7wVtPhsjUmcOQwSMXnbqAEt0k_CWxoUiiEYZmlZ_lBg";
	const string publicCode = "59fa6dd76b2b659298e2088e";
	const string webURL = "http://dreamlo.com/lb/";

	public string a;

	public void AddNewHighScore (string username, int score, int time){
		if (username == "") {
			username = "Anon";
		}
		StartCoroutine (UploadNewHighscore (username, score, time));
	}

	IEnumerator UploadNewHighscore(string username, int score, int time){
		WWW www = new WWW (webURL + privateCode + "/add/" + WWW.EscapeURL (username) + "/" + score + "/" + time);
		yield return www;

		if (string.IsNullOrEmpty (www.error)) {
			print ("Upload Succesful");
		} else {
			print ("error: " + www.error);
		}
	}

	void Start(){
		Debug.Log (control.instance.pname);
		AddNewHighScore (control.instance.pname, control.instance.score, Mathf.RoundToInt(control.instance.tim));
	}
	void Update(){
		if (Input.GetKeyUp ("space") || Input.GetKeyUp ("enter") || Input.GetKeyUp("return")) {
			control.instance.score = 0;
			SceneManager.LoadScene (a);
		}
	}
	// Use this for initialization
	public void onclick(){
		control.instance.score = 0;
		control.instance.win = false;
		SceneManager.LoadScene (a);
	}
}
