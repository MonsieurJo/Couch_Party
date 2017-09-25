﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 18;

	public float turnSpeed = 50;

	private Rigidbody rig;


	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float hAxis = Input.GetAxis("J1Horizontal");
		float vAxis = Input.GetAxis("J1Vertical");

		float leftTrigger = Input.GetAxis("J1LeftTrigger");
		float rightTrigger = Input.GetAxis("J1RightTrigger");

		Vector3 movement = transform.TransformDirection(new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime);
	}
}