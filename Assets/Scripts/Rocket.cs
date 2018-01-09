﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
        		
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("Thrust");
        }
        if (Input.GetKey(KeyCode.A)) {
            print("Rotate Left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Rotate Right");
        }
       
    }
}
