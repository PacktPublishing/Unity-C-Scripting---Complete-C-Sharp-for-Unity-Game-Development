using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		       
//		print (" Before Entering For Loop ");
//
//		for( int i = 1 ; i < 5 ; i++ ){
//
//			print (" Raja ");
//		}
//
//		print (" After Exiting for loop");


		print (" Before Entering For Loop ");

		int i = 1;

		     // 11 <= 10
		while(i <= 10){
			// print name 5 times
			print(i);

			i++; // 10 -> 11
		}

		print (" After Exiting for loop");


		// Infinite loops

//		int j = 5;
//
//		while (j < 10) {
//
//			print (" Loop Is Running ");
//		
//		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
