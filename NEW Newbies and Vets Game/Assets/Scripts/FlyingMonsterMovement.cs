using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingMonsterMovement : PhysicsObject
{
    public Transform player;
    public GameObject[] players;
    public Vector2 move = Vector2.zero;
    public float maxSpeed = 2;
    private float nextActionTime = 20.0f;
    public float period = 20.1f;
    public float randomDistX;
    public float randomDistY;
    // Use this for initialization
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        if (Vector2.Distance(transform.position, players[0].transform.position) <= Vector2.Distance(transform.position, players[1].transform.position))
        {
            player = players[0].transform;
        }
        else if (Vector2.Distance(transform.position, players[0].transform.position) > Vector2.Distance(transform.position, players[1].transform.position))
        {
            player = players[1].transform;
        }
        if (Random.value < .5)
        {
            randomDistX = Mathf.Max(Random.value * 2, 1);
        }
        else
        {
            randomDistX = -Mathf.Max(Random.value * 2, 1);
        }
        if (Random.value < .5)
        {
            randomDistY = Mathf.Max(Random.value * 2, 1);
        }
        else
        {
            randomDistY = -Mathf.Max(Random.value * 2, 1);
        }
        gravityModifier = 0;
    }

    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, players[0].transform.position) <= Vector2.Distance(transform.position, players[1].transform.position))
        {
            player = players[0].transform;
        }
        else if (Vector2.Distance(transform.position, players[0].transform.position) > Vector2.Distance(transform.position, players[1].transform.position))
        {
            player = players[1].transform;
        }

        if (period > nextActionTime || Vector3.Distance(player.position, transform.position) > 5)
        {
            if (Random.value < .5)
            {
                randomDistX = Mathf.Max(Random.value * 2, 1);
            }
            else
            {
                randomDistX = -Mathf.Max(Random.value * 2, 1);
            }
            if (Random.value < .5)
            {
                randomDistY = Mathf.Max(Random.value * 2, 1);
            }
            else
            {
                randomDistY = -Mathf.Max(Random.value * 2, 1);
            }
            period = 0.0f;
        }
        Vector3 nearPlayer = player.position + new Vector3(randomDistX, randomDistY, 0);
        transform.position = Vector3.MoveTowards(transform.position, nearPlayer, maxSpeed * Time.deltaTime);
        period += .1f;


    }
    public void TakeDamage(int damage) { 
    
    }
}



