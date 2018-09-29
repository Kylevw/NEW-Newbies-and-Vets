using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Joystick_Controls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("P2_Jump"))
        {
            Debug.Log("P2 Jump");
        }

        if (Input.GetButton("P2_Interact"))
        {
            Debug.Log("P2 Interacting");
        }

        if (Input.GetButton("P2_PFire"))
        {
            Debug.Log("P2 Pfiring");
        }

        if (Input.GetButton("P2_SFire"))
        {
            Debug.Log("P2 Sfiring");
        }

        if (Input.GetAxis("P2_Move") < 0)
        {
            Debug.Log("P2 Left");
        }

        if (Input.GetAxis("P2_Move") > 0)
        {
            Debug.Log("P2 Right");
        }

    }
}
