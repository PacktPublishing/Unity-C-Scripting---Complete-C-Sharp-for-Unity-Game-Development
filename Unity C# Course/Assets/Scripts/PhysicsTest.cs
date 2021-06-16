using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour {

	Rigidbody rb;
	public float speed;
	public int jumpForce;

	public float bulletSpeed;
	bool shoot = false;


	bool jump = false;

	float inputX, inputY;

	public GameObject bullet;
	public Transform bulletPos;


	void Awake(){

		rb = GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {

		//rb.velocity = new Vector3 (0, 0, speed);

	}
	
	// Update is called once per frame
	void Update () {

		inputX = Input.GetAxis ("Horizontal");
		inputY = Input.GetAxis ("Vertical");

		if (Input.GetButtonDown ("Jump")) {

			jump = true;
		
		}

		if (Input.GetButtonDown ("Fire1")) {
		
			shoot = true;


		}

	}

	void FixedUpdate(){

		rb.velocity = new Vector3 (inputX * speed, rb.velocity.y, inputY * speed);

		if (jump) {
			
			Jump ();

			jump = false;
		}

		if (shoot) {
		
			Shoot ();

			shoot = false;
		}
	}

	void Jump(){

		rb.AddForce (0, jumpForce, 0);
	
	}

	void Shoot(){

		GameObject bulletSpawn = Instantiate (bullet, bulletPos.position, bullet.transform.rotation);

		bulletSpawn.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, bulletSpeed);
	}


}
