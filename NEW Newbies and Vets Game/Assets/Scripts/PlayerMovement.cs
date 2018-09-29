using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PhysicsObject {
    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 15;
    public float playerID;

	// Use this for initialization
	void Start () {
		
	}
	
    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;
        move.x = Input.GetAxis("P" + playerID +"_Move");
        if(move.x < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else if(move.x > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }


        if(Input.GetButtonDown("P" + playerID +"_Jump") && grounded)
        {
            velocity.y = jumpTakeOffSpeed;
        }
        
        targetVelocity = move*maxSpeed;
    }
}
