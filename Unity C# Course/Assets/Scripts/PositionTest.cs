using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTest : MonoBehaviour {

	public float speed = 1f;

	//Vector3 pos;

	// Use this for initialization
	void Start () {


//		int x = 5;
//
//		x = x + 5; //10
//		x += 5;

//		pos = new Vector3 (1f, 2f, 3f);
//		print (pos.y);


		//print (transform.position);

		//transform.position = new Vector3 (0, 0, 0);

		//transform.position = transform.position + new Vector3 (1f, 0, 0);

		//transform.position += new Vector3 (1f, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {

		//transform.position += new Vector3 (0,1f, 0);

		//transform.position += transform.forward * speed; // (0 , 0 , 1)

		//transform.Translate (speed, 0, 0);

		transform.Rotate (speed, 0, 0);

		//transform.localScale += new Vector3 (0, speed, 0);

		transform.localScale += transform.up * speed;


	}
}
