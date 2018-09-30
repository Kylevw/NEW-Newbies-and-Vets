using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwoopingMonsterSpawner : MonoBehaviour
{

    public GameObject[] SwoopingPrefab;
    public float spawnTime;
    public float timeTilSpawn;
    void Update()
    {
        if (timeTilSpawn <= 0.0f)
        {
            Instantiate(SwoopingPrefab[(int)(SwoopingPrefab.Length * Random.value)], transform.position, Quaternion.identity);
            timeTilSpawn = spawnTime;
            spawnTime = Random.value * 4 + 4;
        }
        timeTilSpawn -= Time.deltaTime;
    }
}
