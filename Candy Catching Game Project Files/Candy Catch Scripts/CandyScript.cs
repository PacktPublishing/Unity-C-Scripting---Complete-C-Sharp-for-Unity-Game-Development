using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            //Increment Score
            GameManager.instance.InrementScore();
            Destroy(gameObject);
        }

        else if(collider.gameObject.tag == "Boundary")
        {
            //Decrease Lives
            GameManager.instance.DecreaseLife();
            Destroy(gameObject);
        }

    }

}
