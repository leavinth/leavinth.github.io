using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour {
	public Transform player;	// Use this for initialization
	public Vector3 offset;
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.position + offset;
	}
}
