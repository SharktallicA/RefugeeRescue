﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.GetChild(0).LookAt(GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>());
    }
}