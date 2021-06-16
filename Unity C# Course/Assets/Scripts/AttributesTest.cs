using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AttributesTest : MonoBehaviour {


    //[SerializeField]
    //private int speed;

    //[HideInInspector]

    //[Range(0,20)]

    public int speed;

    Rigidbody rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(speed * Time.deltaTime, 0, 0);

        GetComponent<Rigidbody>().isKinematic = false;

	}
}
