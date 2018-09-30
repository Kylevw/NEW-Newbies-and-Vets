using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () { 
		
	}
	
	// Update is called once per frame
	void Update () {
		


	}

    void OnTriggerEnter2D(Collider2D col)
    {

        Debug.Log("Teleported");

        GameObject Obj = col.gameObject;

        if (Obj.CompareTag("Player"))
        {
            Obj.transform.position = new Vector2(0, -2);
        }

    }
}
