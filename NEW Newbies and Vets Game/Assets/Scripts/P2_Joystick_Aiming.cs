using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Joystick_Aiming : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float inputX = Input.GetAxis("P2_AimX");
        float inputY = Input.GetAxis("P2_AimY");

        if (inputX != 0 || inputY != 0)
        {
            Vector2 aimDirection = new Vector2(inputX, inputY);

            Debug.Log(aimDirection);
        }

    }
}
