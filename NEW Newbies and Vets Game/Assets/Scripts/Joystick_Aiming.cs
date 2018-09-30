using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick_Aiming : MonoBehaviour {

    public float playerID;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("P" + playerID + "_AimX");
        float inputY = Input.GetAxis("P" + playerID + "_AimY");

        if(inputX != 0 || inputY != 0)
        {
            Vector2 aimDirection = new Vector2(inputX, inputY);
        }

        if (inputX != 0 && inputY != 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, Mathf.Atan2(inputY, inputX) * (180 / Mathf.PI));
        }
    }

}
