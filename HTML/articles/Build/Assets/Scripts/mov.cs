using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour {
	public float speed;
	public float jump;
	public float downB;
	public Rigidbody2D rb;
	public bool isground = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey("right") || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Keypad6)) {
			rb.AddForce (Vector2.right * speed * 1f);
		
		}
		if (Input.GetKey("left") || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.Keypad4)) {
			rb.AddForce (Vector2.left * speed * 1f);
		
		}
		if (Input.GetKeyDown ("up")  || Input.GetKeyDown(KeyCode.W)  || Input.GetKeyDown(KeyCode.Keypad8)) {
			if (isground == true) {
				rb.velocity = new Vector2 (0, jump);
			}
		} 
		if (Input.GetKey ("down")  || Input.GetKey(KeyCode.S)  || Input.GetKey(KeyCode.Keypad2)) {
			rb.AddForce (Vector2.down * downB);
		}

	}
	void OnCollisionEnter2D (Collision2D col){
		if(col.gameObject.tag == "platform")
		{
			isground = true;
		}
	}
	void OnCollisionStay2D(Collision2D col){
		if(col.gameObject.tag == "platform")
		{
			isground = true;
		}
	}
	void OnCollisionExit2D (Collision2D col){
		if(col.gameObject.tag == "platform")
		{
			isground = false;
		}
	}
}
