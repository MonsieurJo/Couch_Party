using System.Collections;
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

		//float leftTrigger = Input.GetAxis("J1LeftTrigger");
		float rightTrigger = Input.GetAxis("J1RightTrigger");

		Vector3 movement = transform.TransformDirection(new Vector3(hAxis, 0f, vAxis) * speed * Time.deltaTime);

		rig.MovePosition(transform.position + movement);

		if (Input.GetButtonDown("J1A")){
			Debug.Log("A");
		}
		if(Input.GetButtonDown("J1B")){
			Debug.Log("B");
		}
		if(Input.GetButtonDown("J1Start")){
			Debug.Log("Start");
		}
		if(hAxis < 0f){
			Debug.Log("Horizontal:" + hAxis.ToString());
		}
		if(rightTrigger != 0f){
			Debug.Log("Right Trigger value:" +  rightTrigger.ToString());
		}
	}
}
