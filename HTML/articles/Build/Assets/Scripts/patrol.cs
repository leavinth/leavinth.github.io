using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour {
	public float distance;
	public float speed;
	private float startpos;
	public bool horizontal;
	public int direction;
	private float point1;
	private float point2;
	public float offsetx;
	public float offsety;
	// Use this for initialization
	void Start () {
		if (horizontal == true) {
			startpos = transform.localPosition.x;
		} else {
			startpos = transform.localPosition.y;
		}
		point1 = startpos - distance;
		point2 = startpos + distance;
		transform.localPosition += new Vector3 (offsetx, offsety, 0);
	}

	// Update is called once per frame
	void FixedUpdate () {
		float realpos;
		if (horizontal == true) {
			realpos = transform.localPosition.x;
		} else {
			realpos = transform.localPosition.y;
		}
		if (realpos < point1) {
			direction = 1;
		} else if (realpos > point2) {
			direction = -1;
		}
		if (horizontal == true) {
			transform.localPosition += new Vector3 (direction * speed * 0.1f, 0f, 0f);
		} else if (horizontal == false) {
			transform.localPosition += new Vector3 (0f, direction * speed * 0.5f ,0f);
		}
		}
	}
