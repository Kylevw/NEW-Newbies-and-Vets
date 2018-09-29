using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_Joystick_Controls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("P1_Jump"))
        {
            Debug.Log("P1 Jump");
        }

        if (Input.GetButton("P1_Interact"))
        {
            Debug.Log("P1 Interacting");
        }

        if (Input.GetButton("P1_PFire"))
        {
            Debug.Log("P1 Pfiring");
        }

        if(Input.GetButton("P1_SFire"))
        {
            Debug.Log("P1 Sfiring");
        }

        if (Input.GetAxis("P1_Move") < 0)
        {
            Debug.Log("P1 Left");
        }

        if (Input.GetAxis("P1_Move") > 0)
        {
            Debug.Log("P1 Right");
        }

    }
}
