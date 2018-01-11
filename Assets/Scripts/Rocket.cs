﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    Rigidbody rigidBody;
    int rcsTrust = 0;
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
            rigidBody.AddRelativeForce(Vector3.up);
        }
        if (Input.GetKey(KeyCode.A)) {
            print("Rotate Left");
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Rotate Right");
            transform.Rotate(-Vector3.forward);

        }

    }
}
