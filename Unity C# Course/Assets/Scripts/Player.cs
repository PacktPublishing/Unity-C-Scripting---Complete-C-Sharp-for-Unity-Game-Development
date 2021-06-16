using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Score score = new Score();

        //score.Point = 7;

       // print(score.Point);

        //score.Point = 4;

        //print(score.Point);

        score.Lives = 5;

        print(score.Lives);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
