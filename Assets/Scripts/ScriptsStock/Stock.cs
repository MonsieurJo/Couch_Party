﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock : MonoBehaviour {

    public int addStock;
    public int maxStock;
    private int currentStock;
    public GameObject stockable;
    public GameObject container;

	// Use this for initialization
	void Start () {
        currentStock = 0;
	}
	
	// Update is called once per frame
	void Update () {
      
	}

    private void OnTriggerEnter(Collider stockable)
    {

        if (currentStock <= maxStock)
        Destroy(stockable.gameObject);
        currentStock = currentStock + addStock;
    }

}
