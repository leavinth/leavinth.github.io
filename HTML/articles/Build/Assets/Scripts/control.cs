using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
	public static control instance = null;
	public int score;
	public Dictionary<string,int> leaderboards = new Dictionary<string,int>();
	public string pname;
	public System.Random rand = new System.Random();
	public bool full = false;
	public int screenWidth = Screen.width;
	public int screenHeight = Screen.height;
	public bool win;
	public float tim;
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
		
	}
}
