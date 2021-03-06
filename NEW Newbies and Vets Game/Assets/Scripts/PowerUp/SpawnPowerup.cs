﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerup : MonoBehaviour {

    public GameObject[] powerups; //array of powerups to be added in editor

    int whichPowerUp;

    public float spawnTimeMax;
    public float spawnTimeMin;

    float timeToSpawn;

    bool powerUpSpawned = false;
    
    // Use this for initialization
    void Start()
    {

        timeToSpawn = (Random.value * (spawnTimeMax - spawnTimeMin)) + spawnTimeMin;


    }

    // Update is called once per frame
    void Update()
    {


        timeToSpawn -= Time.deltaTime;

        if (timeToSpawn <= 0)
        {

            if (powerUpSpawned == false)
            {
                int whichPowerUp = Random.Range(0, powerups.Length + 1);

                Instantiate(powerups[whichPowerUp], this.transform.position, this.transform.rotation);
                powerUpSpawned = true;


            }

            if (!powerups[whichPowerUp])
            {
                timeToSpawn = (Random.value * (spawnTimeMax - spawnTimeMin)) + spawnTimeMin;
                powerUpSpawned = false;
            }

        }
    }
}
