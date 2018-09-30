using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMonsterMovement : PhysicsObject {
    public Transform player;
    public float minTriggerDistance;
    public float maxTriggerDistance;
    public float maxSpeed = 2;
    public float timeTilChange;
    public float currentTime;
    protected Vector2 move = Vector2.zero;
    
    
    public GameObject[] players;
    void Start () {
        currentTime = timeTilChange;
        players = GameObject.FindGameObjectsWithTag("Player");
        
        if (players.Length == 2)
        {
            if (Vector2.Distance(transform.position, players[0].transform.position) <= Vector2.Distance(transform.position, players[1].transform.position))
            {
                player = players[0].transform;
            }
            else if (Vector2.Distance(transform.position, players[0].transform.position) > Vector2.Distance(transform.position, players[1].transform.position))
            {
                player = players[1].transform;
            }
        }
        else
        {
            player = players[0].transform;
        }

    }
    protected override void ComputeVelocity()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        if (players.Length == 2)
        {
            if (Vector2.Distance(transform.position, players[0].transform.position) <= Vector2.Distance(transform.position, players[1].transform.position))
            {
                player = players[0].transform;
            }
            else if (Vector2.Distance(transform.position, players[0].transform.position) > Vector2.Distance(transform.position, players[1].transform.position))
            {
                player = players[1].transform;
            }
        }
        else
        {
            player = players[0].transform;
        }
        
            if (Mathf.Abs(player.position.x - transform.position.x) <= maxTriggerDistance && Mathf.Abs(player.position.x - transform.position.x) > minTriggerDistance )
            {
                if (player.position.x > transform.position.x)
                {
                    move = Vector2.right;
                }
                else
                {
                    move = Vector2.left;
                }
                targetVelocity = move * maxSpeed;
            }
            else if (Mathf.Abs(player.position.x - transform.position.x) > maxTriggerDistance)
            {
                if (currentTime <= 0.0f)
                {
                    if (Random.value < .333)
                    {
                        move = Vector2.right;
                    }
                    else if (Random.value > .667)
                    {
                        move = Vector2.left;
                    }
                    else
                    {
                        move = Vector2.zero;
                    }
                    currentTime = timeTilChange;
                }
                currentTime -= Time.deltaTime;
                targetVelocity = move * (maxSpeed );
            }

            else
            {
                move = Vector2.zero;
                targetVelocity = move * maxSpeed;
            }
        
       





    }


}
