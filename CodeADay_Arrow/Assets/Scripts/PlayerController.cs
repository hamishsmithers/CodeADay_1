using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject arrow;
	public float fireDelta = 0.5F;
	public GameObject realBow;

	private float nextFire = 0.5F;
	private GameObject newProjectile;
	private float myTime = 0.0F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTime = myTime + Time.deltaTime;
		if (Input.GetAxis ("Horizontal")<0) {
			transform.Rotate (0.0f, 0.0f, 1.0f);
		}
		if (Input.GetAxis ("Horizontal")>0) {
			transform.Rotate (0.0f, 0.0f, -1.0f);
		}
		if (Input.GetButton ("Fire1")&& myTime > nextFire) {
			nextFire = myTime + fireDelta;
			newProjectile = Instantiate (arrow, realBow.transform.position, transform.rotation) as GameObject;

			nextFire = nextFire - myTime;
			myTime = 0.0f;
		}
		
	}
}
