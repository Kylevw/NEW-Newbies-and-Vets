﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingMonsterMovement : PhysicsObject
{
    public Transform player;
    public GameObject enemyProjPrefab;
    public GameObject[] players;
    public Vector2 move = Vector2.zero;
    public float maxSpeed = 2;
    public float nextActionTime;
    public float period;
    public float stayAwayDistance;
    public float bulletDelay;
    public float bulletTime;
    public float randomDistX;
    public float randomDistY;
    private string direction;
    public bool isShooting;
    // Use this for initialization
    void Start()
    {

        isShooting = true;
        players = GameObject.FindGameObjectsWithTag("Player");
        if (players.Length == 2) {
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
        if (Random.value < .5)
        {
            randomDistX = Mathf.Max(Random.value * stayAwayDistance, stayAwayDistance/2);
        }
        
        else
        {
            randomDistX = -Mathf.Max(Random.value * stayAwayDistance, stayAwayDistance / 2);
        }
        if (Random.value < .5)
        {
            randomDistY = Mathf.Max(Random.value * stayAwayDistance, stayAwayDistance / 2);
        }
        else
        {
            randomDistY = -Mathf.Max(Random.value * stayAwayDistance, stayAwayDistance / 2);
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

        if (period <= 0.0)
        {
            isShooting = !isShooting;
            period = nextActionTime;
            nextActionTime = Random.value * 3 + 2;
            if (Random.value < .5)
            {
                randomDistX = Mathf.Max(Random.value * stayAwayDistance, stayAwayDistance / 2);
            }
            else
            {
                randomDistX = -Mathf.Max(Random.value * stayAwayDistance, stayAwayDistance / 2);
            }
            randomDistY = Random.value * stayAwayDistance;
        }

        if (!isShooting)
        {
            Vector3 nearPlayer = player.position + new Vector3(randomDistX, randomDistY, 0);
            transform.position = Vector3.MoveTowards(transform.position, nearPlayer, maxSpeed * Time.deltaTime);
            period -= Time.deltaTime;
            if (nearPlayer.x > transform.position.x)
            {
                direction = "left";
            }
            else if (nearPlayer.x < transform.position.x)
            {
                direction = "right";
            }
        }
        else
        {
            /*if (bulletTime <= 0.0f)
            {
                Instantiate(enemyProjPrefab, transform.position, Quaternion.identity);
                bulletTime = bulletDelay;
                bulletDelay = Random.value*.5+.5;
            }
            
                bulletTime -= Time.deltaTime;
            */
            period -= Time.deltaTime;
        }

    }
    public void TakeDamage(int damage) { 
    
    }

    public string getDirection()
    {
        return direction;
    }
}



