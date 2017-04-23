using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBall : MonoBehaviour {
	public float INIT_DEGREE = 75f;
	public float INIT_SPEED = 40f;

	// Use this for initialization
	void Start () {
		shotBall ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void shotBall(){
		Vector3 vel = Vector3.zero;
		vel.x = INIT_SPEED * Mathf.Cos (INIT_DEGREE * Mathf.PI / 180f);
		vel.y = INIT_SPEED * Mathf.Sin (INIT_DEGREE * Mathf.PI / 180f);
		GetComponent<Rigidbody>().velocity = vel;
	}
}
