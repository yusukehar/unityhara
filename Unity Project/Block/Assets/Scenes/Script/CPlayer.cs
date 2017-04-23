using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayer : MonoBehaviour {
	public float VEL = 40f;
	public GameObject prefBall = null;
   	GameObject insBall = null;


	void Start () {
		createHoldBall ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 vel = Vector3.zero;
		vel.x = VEL * Input.GetAxisRaw ("Horizontal");
		GetComponent<Rigidbody> ().velocity = vel;
	}

	void createHoldBall(){
		Vector3 bpos = transform.position;
		bpos.y += (GetComponent<Collider> ().bounds.size.y + prefBall.transform.localScale.y) / 2f;
		insBall = (GameObject)Instantiate (prefBall, bpos, Quaternion.identity);
		insBall.transform.parent = transform;
	}
}
