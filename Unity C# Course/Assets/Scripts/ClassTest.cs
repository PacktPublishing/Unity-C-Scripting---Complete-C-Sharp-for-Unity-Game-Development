using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassTest : MonoBehaviour {


    public Car myCar;

    // Use this for initialization
    void Start () {

        //Car myCar = new Car();
        //myCar.speed = 10.5f;
        //myCar.color = "Red";
        //myCar.highestSpeed = 20;


        //Car suzuki = new Car();
        //suzuki.speed = 15f;
        //suzuki.color = "Green";
        //suzuki.highestSpeed = 30;

        //myCar.CarSpeed();

        //suzuki.CarSpeed();

        //Car myCar2 = new Car(2.5f,"Red");

        myCar.PrintCarDetails();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
