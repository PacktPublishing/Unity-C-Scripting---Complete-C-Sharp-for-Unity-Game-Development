using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTest2 : MonoBehaviour {

	public GameObject[] objects;

	// Use this for initialization
	void Start () {

		foreach(GameObject o in objects ){

			o.SetActive (true);
			//Destroy (o);
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
