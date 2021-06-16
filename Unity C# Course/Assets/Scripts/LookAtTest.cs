using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTest : MonoBehaviour {

    public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 newPos = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);

        //transform.LookAt(target.transform);

        transform.LookAt(newPos);
 
	}
}
