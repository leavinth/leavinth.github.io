using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playernamerinput : MonoBehaviour {

	public InputField maininput;

	public static playernamerinput instance = null;
	void Awake() {
		if (instance == null) {
			instance = this;
		}
		else if (instance != this){
			Destroy(gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		control.instance.pname = maininput.textComponent.text;
	}
}
