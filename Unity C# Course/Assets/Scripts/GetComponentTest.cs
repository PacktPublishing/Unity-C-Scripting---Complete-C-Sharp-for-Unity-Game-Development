using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentTest : MonoBehaviour {

	Rigidbody rb;

	PlayerHealth health;

	// Use this for initialization
	void Start () {

//		rb = GetComponent<Rigidbody> ();
//
//		rb.useGravity = false;
//		rb.mass = 10;


		//GetComponent<Renderer> ().material.color = Color.red;

//			health = GetComponent<PlayerHealth> ();
//			health.lives = 9;


		GetComponentInChildren<Rigidbody> ().useGravity = true;

		GetComponentInParent<Rigidbody> ().mass = 5;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
