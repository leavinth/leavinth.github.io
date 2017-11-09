using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class onreleaseexit : MonoBehaviour {
	public void Start(){
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.WebGLPlayer) {
			Destroy (gameObject);
		}
	}
	// Use this for initialization
	public void onclick(){
		Application.Quit ();
	}
}
