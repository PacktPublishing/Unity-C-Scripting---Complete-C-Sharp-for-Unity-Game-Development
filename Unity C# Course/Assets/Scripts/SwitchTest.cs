using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour {

    public int power = 0;

	// Use this for initialization
	void Start () {
	    	
	}

    // Update is called once per frame
    void Update()
    {

        switch (power)
        {
            case 1:
                print("You Are Beginner Player");
                break;
            case 2:
                print("You Are Intermediate Player");
                break;
            case 3:
                print(" You Are an Advanced Player");
                break;
            default:
                print(" You Are Not a Player" );
                break;

        }

    }


        
}
