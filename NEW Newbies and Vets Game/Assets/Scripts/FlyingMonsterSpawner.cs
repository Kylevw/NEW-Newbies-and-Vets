
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingMonsterSpawner : Spawner { 

    public GameObject[] FlyingPrefab;
    public float spawnTime;
    public float timeTilSpawn;
    public override void Spawn()
    {
        Instantiate(FlyingPrefab[(int)(FlyingPrefab.Length * Random.value)], transform.position, Quaternion.identity);
    }
}

