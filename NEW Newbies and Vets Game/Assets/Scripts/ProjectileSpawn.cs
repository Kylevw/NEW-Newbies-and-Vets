using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour {

    public GameObject projectile;
    public float speed;

    private float playerID;

	// Use this for initialization
	void Start () {

        playerID = GetComponentInParent<PlayerMovement>().getID();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("P" + playerID + "_PFire"))
        {
            Destroy(Instantiate(projectile, transform.position, transform.rotation), 2);
    
        }

    }
}
