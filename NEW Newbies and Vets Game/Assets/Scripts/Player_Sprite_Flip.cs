using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Sprite_Flip : MonoBehaviour {

    public float playerID;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("P"+playerID+"_Move") < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetAxis("P"+playerID+"_Move")> 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
