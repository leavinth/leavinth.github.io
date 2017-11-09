using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {
	Text words;
	// Use this for initialization
	void Start () {
		words = GetComponent<Text> ();
		words.text = "Score: " + control.instance.score.ToString () + "\n Time: " + control.instance.tim.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		words.text = "Score: " + control.instance.score.ToString () + "\n Time: " + control.instance.tim.ToString();
	}
}
