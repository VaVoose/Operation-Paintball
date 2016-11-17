using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Movement : MonoBehaviour {
	public int maxSpeed = 5;
	public float currentSpeed = 0.0f;
	public float acceleration = .03f;
	public float decceleration = .01f;
	public float startAccel = 0.0f;

	void FixedUpdate(){
        if (currentSpeed != 0 && Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.S))
        {
            currentSpeed = Mathf.Lerp(currentSpeed, startAccel, Time.time * decceleration);
            acceleration = 0;
        }
        else {
            if (currentSpeed < Max)
        }


		 
	}



}
