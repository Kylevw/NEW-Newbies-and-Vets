
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMonsterSpawner : Spawner
{
    public GameObject[] GroundPrefab;
    public float spawnTime;
    public float timeTilSpawn;
    public override void Spawn()
    {
        Instantiate(GroundPrefab[(int)(GroundPrefab.Length * Random.value)], transform.position, Quaternion.identity);
    }
}

