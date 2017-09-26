using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody playerRb;
	public GameObject playerGrabPosition;
	private float leftTrigger;
	private float rightTrigger;
	private float hAxis;
	private float vAxis;
	private bool aButton;
	private bool bButton;
	private bool startButton;
	private bool isGrabbing = false;
	private Rigidbody objectGrabbedRb;
	private GameObject objectGrabbed;
	public float thrust;
	public int playerNumber;


	// Use this for initialization
	void Start () {
		playerRb = GetComponent<Rigidbody>();
		if (gameObject.CompareTag("J1")){
			playerNumber = 1;
		}else if (gameObject.CompareTag("J2")){
			playerNumber = 2;
		}else if (gameObject.CompareTag("J3")){
			playerNumber = 3;
		}else if (gameObject.CompareTag("J4")){
			playerNumber = 4;
		}
	}
	
	// Update is called once per frame
	void Update () {
		MoveManager();
		GrabManager();
	}

	void MoveManager(){
		hAxis = Input.GetAxis("J"+playerNumber.ToString()+"Horizontal");
		vAxis = Input.GetAxis("J"+playerNumber.ToString()+"Vertical");

		aButton = Input.GetButtonDown("J"+playerNumber.ToString()+"A");
		bButton = Input.GetButtonDown("J"+playerNumber.ToString()+"B");
		startButton = Input.GetButtonDown("J"+playerNumber.ToString()+"Start");
		
		Vector3 movement = new Vector3(hAxis, 0.0f, vAxis);
		
		playerRb.AddForce(movement.normalized * speed, ForceMode.Impulse);

		if (movement != Vector3.zero){
    		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.2f);
		}


		// Vector3 movement = transform.TransformDirection(new Vector3(hAxis, 0f, vAxis) * speed * Time.deltaTime);
		// transform.rotation = Quaternion.LookRotation(movement);
		// transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), 0.2f);

		// if (aButton){
		// 	Debug.Log("A");
		// }
		// if(bButton){
		// 	Debug.Log("B");
		// }
		// if(startButton){
		// 	Debug.Log("Start");
		// }
		// if(hAxis != 0f){
		// 	Debug.Log("Horizontal:" + hAxis.ToString());
		// }
		// if(rightTrigger != 0f){
		// 	Debug.Log("Right Trigger value:" +  rightTrigger.ToString());
		// }
		// if(leftTrigger != 0f){
		// 	Debug.Log("Left Trigger value:" + leftTrigger.ToString());
		// }
		// if (vAxis != 0f){
		// 	Debug.Log("Vertical :" + vAxis.ToString());
		// }
	}

	void GrabManager(){
		leftTrigger = Input.GetAxis("J"+playerNumber.ToString()+"LeftTrigger");
		rightTrigger = Input.GetAxis("J"+playerNumber.ToString()+"RightTrigger");
	}

	// void OnTriggerStay (Collider other){
	// 	if (other.gameObject.CompareTag("Item")){
	// 		if (rightTrigger > 0.70f){
	// 			other.gameObject.transform.position = playerGrabPosition.transform.position;
	// 			isGrabbed = true;
	// 			isGrabbing = true;
	// 			objectGrabbedRb = other.GetComponent<Rigidbody>();
	// 			objectGrabbedRb.isKinematic = true;
	// 			objectGrabbed = other.gameObject;
	// 		}else if(rightTrigger < 0.70f){
	// 			other.gameObject.transform.position = other.gameObject.transform.position;
	// 			objectGrabbedRb.isKinematic = false;
	// 			objectGrabbedRb = null;
	// 			objectGrabbed = null;
	// 			isGrabbed = false;
	// 			isGrabbing = false;
	// 		}
	// 	}
	// }
}
