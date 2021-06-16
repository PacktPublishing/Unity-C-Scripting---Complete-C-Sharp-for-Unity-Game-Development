using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour {

	public GameObject ball;

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.Space)) {
//		
//			print (" Space Button Pressed First Time ");
//
//			GetComponent<Renderer> ().material.color = Color.green;
//		}
//
//		if (Input.GetKeyUp (KeyCode.Space)) {
//
//			print (" Space Button Released ");
//
//			GetComponent<Renderer> ().material.color = Color.yellow;
//		}
//
//		if (Input.GetKey (KeyCode.Space)) {
//
//			print (" Space Button Held Down ");
//		}

//		if (Input.GetButtonDown ("Jump")) {
//		
//			print (" Space Button Pressed First Time ");
//
//			GetComponent<Renderer> ().material.color = Color.green;
//		}
	


//		float xInput = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
//
//		float yInput = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
//
//		Input.GetAxisRaw ("Horizontal");
//
//		print (xInput);
//
//		transform.Translate (xInput , yInput, 0);


//		if (Input.GetButtonDown ("Fire1")) {
//
//			print (" Left Click");
//		
//		}
//

//		if (Input.GetMouseButtonDown (0)) {
//
//			//print (" Left Click ");
//
//			print (Input.mousePosition.x + " " + Input.mousePosition.y);
//
//			Vector3 pos = Input.mousePosition;
//			pos.z = 10f;
//
//			pos = Camera.main.ScreenToWorldPoint (pos);
//
//			Instantiate (ball, pos, Quaternion.identity);
//
//		
//		}
//
//		if (Input.GetMouseButtonDown (1)) {
//
//			print (" Right Click ");
//
//		}
//
//		if (Input.GetMouseButtonDown (2)) {
//
//			print (" Wheel Click ");
//
//		}


	}


	void OnMouseDown(){

		Destroy (gameObject);

	}

}
