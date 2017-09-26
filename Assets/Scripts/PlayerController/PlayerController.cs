using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody playerRb;
	public GameObject player;
	private float leftTriggerJ1;
	private float rightTriggerJ1;


	// Use this for initialization
	void Start () {
		playerRb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		MoveManager();
		GrabManager();
	}

	void MoveManager(){
		float hAxisJ1 = Input.GetAxis("J1Horizontal");
		float vAxisJ1 = Input.GetAxis("J1Vertical");



		bool aJ1 = Input.GetButtonDown("J1A");
		bool bJ1 = Input.GetButtonDown("J1B");
		bool startJ1 = Input.GetButtonDown("J1Start");

		Vector3 movement = transform.TransformDirection(new Vector3(hAxisJ1, 0f, vAxisJ1) * speed * Time.deltaTime);

		playerRb.MovePosition(transform.position + movement);

		if (aJ1){
			Debug.Log("A");
		}
		if(bJ1){
			Debug.Log("B");
		}
		if(startJ1){
			Debug.Log("Start");
		}
		if(hAxisJ1 != 0f){
			Debug.Log("Horizontal:" + hAxisJ1.ToString());
		}
		if(rightTriggerJ1 != 0f){
			Debug.Log("Right Trigger value:" +  rightTriggerJ1.ToString());
		}
		if(leftTriggerJ1 != 0f){
			Debug.Log("Left Trigger value:" + leftTriggerJ1.ToString());
		}
		if (vAxisJ1 != 0f){
			Debug.Log("Vertical :" + vAxisJ1.ToString());
		}
	}

	void GrabManager(){
		//leftTriggerJ1 = Input.GetAxis("J1LeftTrigger");
		rightTriggerJ1 = Input.GetAxis("J1RightTrigger");
	}

	void OnTriggerStay (Collider other){
		//bool isGrabbed = false;
		if (other.gameObject.CompareTag("Item")){
			while (rightTriggerJ1 > 0.70f){

				other.gameObject.transform.parent = player.transform;
				//other.gameObject.SetActive(true)
			} //else if(rightTriggerJ1 < 0.70f){
				//other.gameObject.transform.parent = null;
			//}
		}
	}
}
