using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour {

    public static int a;


	// Use this for initialization
	void Start () {

        a++;

        Bullets bullet1 = new Bullets();
        //Bullets.noOfBullets = 10;

        Bullets bullet2 = new Bullets();
        //Bullets.noOfBullets = 20;

        Bullets bullet3 = new Bullets();

        //print(Bullets.noOfBullets);
        //print(bullet2.noOfBullets);

        Bullets.ShowBullets();



	}
	
	// Update is called once per frame
	void Update () {
		
	}
} // StaticTest

public class Bullets
{

    public static int noOfBullets = 0;

    public Bullets()
    {
        noOfBullets++;
    }

    public static void ShowBullets()
    {
        Debug.Log("NO of Bullets :" + noOfBullets);
    }

}
