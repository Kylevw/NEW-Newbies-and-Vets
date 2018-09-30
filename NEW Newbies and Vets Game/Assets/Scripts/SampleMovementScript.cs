using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMovementScript : MonoBehaviour {

    public float speed;
    public float rotationSpeed;
    Vector3 currentMovement;
	
	// Update is called once per frame
	void Update () {

        currentMovement.x = currentMovement.normalized.x + ((Random.value - 0.5f) * (rotationSpeed));
        currentMovement.y = currentMovement.normalized.y + ((Random.value - 0.5f) * (rotationSpeed));
        currentMovement *= speed;

        transform.position += currentMovement * Time.deltaTime;
	}
}
