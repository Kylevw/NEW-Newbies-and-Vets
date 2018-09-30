using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PhysicsObject {

    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 15;

    public float playerID;

    private bool isHit = false;

	// Use this for initialization
	void Start () {
		
	}
	
    protected override void ComputeVelocity()
    {
        if (!isHit)
        {
            Vector2 move = Vector2.zero;
            move.x = Input.GetAxis("P" + playerID + "_Move");
            if (Input.GetButtonDown("P" + playerID + "_Jump") && grounded)
            {
                velocity.y = jumpTakeOffSpeed;
            }

            targetVelocity = move * maxSpeed;
        }
    }

    public bool getHitState()
    {
        return isHit;
    }

    public void SetHitState(bool state)
    {
        isHit = state;
    }

    public void resetVeloicty()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }

    public float getID()
    {
        return playerID;
    }
}
