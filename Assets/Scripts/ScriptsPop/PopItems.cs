using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PopItems : MonoBehaviour {

    public List<GameObject> popRandom = new List<GameObject>();
    private float nbmaxprefab =0f;
    public float spawnInterval = 3.0f;

    private float xRandom;
    private float zRandom;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
		InvokeRepeating("RandoPop", 0.001f, spawnInterval);

		xRandom = UnityEngine.Random.Range(-1,1);
		zRandom = UnityEngine.Random.Range(-1,1);
	}
	
	// Update is called once per frame
	void FixeUpdate () {

		rb.AddForce(xRandom, 0, zRandom, ForceMode.Force);

	}

	void RandoPop () {

		if (nbmaxprefab < 100) {

  			int tempory = UnityEngine.Random.Range(0,popRandom.Count);
  			Instantiate(popRandom[tempory], transform.position, transform.rotation);
        	nbmaxprefab += 1f;

		}

	}


}
