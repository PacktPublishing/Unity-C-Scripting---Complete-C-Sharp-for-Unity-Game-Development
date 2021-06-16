using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiateTest : MonoBehaviour {

	public GameObject[] ball;


	// Use this for initialization
	void Start () {

		//Instantiate (ball, transform.position, Quaternion.identity);

		//Invoke ("RandomBall", 5f);

		InvokeRepeating ("RandomBall", 2f, 1f);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

//			int randomNumber = Random.Range (0, ball.Length); // 0, 3
//		
//			Instantiate (ball[randomNumber], transform.position, Quaternion.identity);
			print(" Mouse Clicked");
			CancelInvoke ("RandomBall");
		}

	}


	void RandomBall(){
	
		int randomNumber = Random.Range (0, ball.Length); // 0, 3

		Instantiate (ball[randomNumber], transform.position, Quaternion.identity);
	
	}

}
