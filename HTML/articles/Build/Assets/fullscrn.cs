using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullscrn : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClick(){
		if (control.instance.full == false) {
			Screen.SetResolution (control.instance.screenWidth, control.instance.screenHeight, true);
			control.instance.full = true;
		} else if (control.instance.full == true) {
			control.instance.full = false;
			Screen.SetResolution (800,413, control.instance.full);
		}
	}
}
