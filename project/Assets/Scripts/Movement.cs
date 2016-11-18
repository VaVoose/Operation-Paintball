using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Movement : MonoBehaviour {
	public float speed = 6;
	public float currentVel = 1;
	public float accel = 0.2f;
	public float deccel = 1f;


	void Update(){
        if (Input.GetKey(KeyCode.W)) {
            Step("w");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Step("s");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Step("d");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Step("a");
        }


    }

    public void Step(string direction) {
        switch (direction) {
            case "w":
                transform.Translate((Vector3.forward * Time.deltaTime)*speed);
                break;
            case "s":
                transform.Translate((Vector3.back * Time.deltaTime)*speed);
                break;
            case "a":
                transform.Translate((Vector3.left * Time.deltaTime)*speed);
                break;
            case "d":
                transform.Translate((Vector3.right * Time.deltaTime)*speed);
                break;

        }
    }



}
