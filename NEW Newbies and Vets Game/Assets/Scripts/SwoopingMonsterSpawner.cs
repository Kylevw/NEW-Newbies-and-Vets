using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwoopingMonsterSpawner : Spawner {

    public GameObject[] SwoopPrefab;
    public float spawnTime;
    public float timeTilSpawn;
    
    public override void Spawn()
    {
        Instantiate(SwoopPrefab[(int)(SwoopPrefab.Length * Random.value)], transform.position, Quaternion.identity);
    }
}
