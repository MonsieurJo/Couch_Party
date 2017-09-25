using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {
	private float rightTriggerJ1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rightTriggerJ1 = Input.GetAxis("J1RightTrigger");

	}

	void OntriggerEnter (Collider other )
	{
		if (other.gameObject.CompareTag ("Item"))
		{
			if (rightTriggerJ1 > 0.70f)
			{
				other.gameObject.SetActive (false);
			}
		}

	}
}