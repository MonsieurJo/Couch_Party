using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 18;

	public float turnSpeed = 50;

	private Rigidbody player;


	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float hAxisJ1 = Input.GetAxisRaw("J1Horizontal");
		float vAxisJ1 = Input.GetAxisRaw("J1Vertical");

		float leftTriggerJ1 = Input.GetAxis("J1LeftTrigger");
		float rightTriggerJ1 = Input.GetAxis("J1RightTrigger");

		bool aJ1 = Input.GetButtonDown("J1A");
		bool bJ1 = Input.GetButtonDown("J1B");
		bool startJ1 = Input.GetButtonDown("J1Start");

		Vector3 movement = transform.TransformDirection(new Vector3(hAxisJ1, 0f, vAxisJ1) * speed * Time.deltaTime);

		player.MovePosition(transform.position + movement);

		/*if (aJ1){
			Debug.Log("A");
		}
		if(bJ1){
			Debug.Log("B");
		}
		if(startJ1){
			Debug.Log("Start");
		}
		if(hAxis != 0f){
			Debug.Log("Horizontal:" + hAxis.ToString());
		}
		if(rightTrigger != 0f){
			Debug.Log("Right Trigger value:" +  rightTrigger.ToString());
		}
		if(leftTrigger != 0f){
			Debug.Log("Left Trigger value:" + leftTrigger.ToString());
		}
		if (vAxis != 0f){
			Debug.Log("Vertical :" + vAxis.ToString());
		}*/
	}
}
