using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour {

	GameObject searchObj;

	GameObject[] enemies;

	// Use this for initialization
	void Start () {

		//searchObj = GameObject.Find ("Cube/Cube2/Enemy");

		//searchObj = GameObject.FindWithTag ("Enemy");

		//enemies = GameObject.FindGameObjectsWithTag ("Enemy");

		//Destroy (searchObj);

//		foreach (GameObject enemy in enemies) {
//		
//			Destroy (enemy);
//		}
//
		//GameObject.Find ("Cube").SetActive (false);

		GameObject.Find ("Cube").GetComponent<Rigidbody> ().useGravity = true;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
