using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwoopingMonsterSpawner : MonoBehaviour {

    public GameObject[] SwoopPrefab;
    public float spawnTime;
    public float timeTilSpawn;
    public float wave;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (timeTilSpawn <= 0.0f)
        {

            Instantiate(SwoopPrefab[(int)(SwoopPrefab.Length * Random.value)], transform.position, Quaternion.identity);
            timeTilSpawn = spawnTime;
        }
        timeTilSpawn -= Time.deltaTime;
    }
}
