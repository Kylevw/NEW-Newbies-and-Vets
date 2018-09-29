using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick_Setup : MonoBehaviour {

    private static int P1;
    private static int P2;

    public static Joystick_Setup JoyCon;

	// Use this for initialization
	void Start () { 

        bool P1found = false;

        //Creates an array of all the joysticks connected to the computer
        string[] joysticks = Input.GetJoystickNames();

        //Checks first to see if there are any joysticks actually plugged in
        if (joysticks.Length > 0)
        {
            //cycles through all indexes of the joysticks array
            for (int count = 0; count < joysticks.Length; count++)
            {
                //if the index is not empty and the first joystick has not been found
                if (!string.IsNullOrEmpty(joysticks[count]) && !P1found)
                {
                    //set the joystick 1's reference to the current index
                    P1 = count;

                    //set P1found to true, next it needs to find the second joystick
                    P1found = true;
                    Debug.Log("Joystick 1 is index: " + P1);
                }

                //if the index is not empty and the first joystick has been found
                else if (!string.IsNullOrEmpty(joysticks[count]) && P1found)
                {
                    //set the joystick 2's reference to the current index
                    P2 = count;

                    Debug.Log("Joystick 2 is index: " + P2);
                }
            }
        }
    }

    void Awake()
    {
        JoyCon = this;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //Get functions for Player 1 joystick controls
    public string getP1Jump()
    {
        return ("joystick " + (P1 + 1) + " button 1");
    }

    public string getP1Interact()
    {
        return ("joystick " + (P1 + 1) + " button 0");
    }

    public string getP1PrimaryFire()
    {
        return ("joystick " + (P1 + 1) + " button 5");
    }

    public string getP1SecondaryFire()
    {
        return ("joystick " + (P1 + 1) + " button 7");
    }

    //Get functions for Player 2 joystick controls
    public string getP2Jump()
    {
        return ("joystick " + (P2 + 1) + " button 1");
    }

    public string getP2Interact()
    {
        return ("joystick " + (P2 + 1) + " button 0");
    }

    public string getP2PrimaryFire()
    {
        return ("joystick " + (P2 + 1) + " button 5");
    }

    public string getP2SecondaryFire()
    {
        return ("joystick " + (P2 + 1) + " button 7");
    }
}
