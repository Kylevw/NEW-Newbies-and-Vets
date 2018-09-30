
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingMonsterSpawner : MonoBehaviour { 

    public GameObject[] FlyingPrefab;
    public float spawnTime;
    public float timeTilSpawn;
    void Update()
    {
        if (timeTilSpawn <= 0.0f)
        {
            Instantiate(FlyingPrefab[(int)(FlyingPrefab.Length * Random.value)], transform.position, Quaternion.identity);
            timeTilSpawn = spawnTime;
            spawnTime = Random.value * 4 + 4;
        }
        timeTilSpawn -= Time.deltaTime;

    }
}

