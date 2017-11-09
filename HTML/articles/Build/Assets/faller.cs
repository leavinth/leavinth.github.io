using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faller : MonoBehaviour {
	private volatile Rigidbody2D rb;

	void Start(){
		rb = GetComponent<Rigidbody2D> ();
	}

	public void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			StartCoroutine("fall");
		}
	}
	IEnumerator fall(){
		yield return new WaitForSecondsRealtime (1);
		rb.bodyType = RigidbodyType2D.Dynamic;
		yield return null;
	}
}
