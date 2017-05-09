using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

	public float speed;
	Rigidbody myRB;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody> ();
		myRB.AddForce (transform.up * speed);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.up = myRB.velocity;
	}

//	void OnCollisionEnter(GameObject other){
//		if(other.tag)
//	}
}
