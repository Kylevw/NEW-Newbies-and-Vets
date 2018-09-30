using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwoopingMonsterMovement : PhysicsObject {

    public Transform player;
    public GameObject[] players;
    public Vector2 move = Vector2.zero;
    public float maxSpeed;
    public float nextActionTime;
    public float period;
    public float flyDistance;
    public bool isSwooping;
    private string direction;

    // Use this for initialization
    void Start()
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
        
        gravityModifier = 0;
    }

    void FixedUpdate()
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

        if (Vector2.Distance(transform.position, player.position) < 3)
        {
            isSwooping = false;
        }
        else if (Vector2.Distance(transform.position, player.position) > flyDistance;)
        {
            isSwooping = true;
        }


        if (isSwooping)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, maxSpeed * Time.deltaTime);
        }
        else
        {
            float rand = flyDistance * Random.value;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(rand + 5, flyDistance - rand + 5, 0), maxSpeed * Time.deltaTime);
        }    

            if (player.position.x > transform.position.x)
            {
                direction = "left";
            }
            else if (player.position.x < transform.position.x)
            {
                direction = "right";
            }
        
        

    }
    public void TakeDamage(int damage)
    {

    }

    public string getDirection()
    {
        return direction;
    }
}
