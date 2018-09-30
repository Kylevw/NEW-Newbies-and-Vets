using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

    public float projectileSpeed;
  

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.TransformDirection(Vector3.right) * projectileSpeed;
        
    }
}
