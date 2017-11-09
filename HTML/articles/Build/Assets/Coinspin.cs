using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Coinspin : MonoBehaviour {

	public Transform rot;
	public int speed;
	private float spin = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (rot.localScale.x >= 1) {
			spin = -0.01f;
		} else if (rot.localScale.x <= -1) {
			spin = 0.01f;
		}
		for (int i = 0; i < speed; i++) {
			rot.localScale += new Vector3 (spin * 0.5f, 0, 0);
		}
	}
}
