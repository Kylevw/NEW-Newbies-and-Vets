using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMovementScript : MonoBehaviour {

    public float speed;
    public float rotationSpeed;
    Vector3 currentMovement;
	
	// Update is called once per frame
	void Update () {

        currentMovement.x += (Random.value - 0.5f) * (rotationSpeed);
        currentMovement.y += (Random.value - 0.5f) * (rotationSpeed);
        currentMovement = currentMovement.normalized * speed;

        transform.position += currentMovement * Time.deltaTime;
	}
}
