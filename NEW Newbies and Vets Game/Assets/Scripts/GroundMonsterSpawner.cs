
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMonsterSpawner : MonoBehaviour
{

    public GameObject[] GroundPrefab;
    public float spawnTime;
    public float timeTilSpawn;
    void Update()
    {
        if (timeTilSpawn <= 0.0f)
        {
            Instantiate(GroundPrefab[(int)(GroundPrefab.Length * Random.value)], transform.position, Quaternion.identity);
            timeTilSpawn = spawnTime;
            spawnTime = Random.value * 3 + 3;
        }
        timeTilSpawn -= Time.deltaTime;

    }
}

