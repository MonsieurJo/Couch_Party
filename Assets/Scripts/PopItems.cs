using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PopItems : MonoBehaviour {
	public GameObject prefabItem;
	public GameObject poper;
    public List<ScriptableItems> popRandom = new List<ScriptableItems>();
    private float nbmaxprefab =0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown("f"))
		{
			RandoPop();
        }
	}

	void RandoPop () {

		if (nbmaxprefab < 100) {

		 	int tempory = UnityEngine.Random.Range(0,popRandom.Count) ;
		 	prefabItem.GetComponent<ApplicationItems>().my_scriptable = popRandom[tempory];
			Instantiate(prefabItem, poper.transform);
        	nbmaxprefab += 1f;

		}

	}

}
