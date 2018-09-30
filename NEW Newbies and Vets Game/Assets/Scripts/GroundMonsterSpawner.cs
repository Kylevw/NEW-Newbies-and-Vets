using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMonsterSpawner : MonoBehaviour
{
    public GameObject[] GroundPrefab;
    public float spawnTime;
    public float timeTilSpawn;
    public float wave;

    // Use this for initialization
    void Start()
    {
        timeTilSpawn = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {

        if (timeTilSpawn <= 0.0f)
        {

            Instantiate(GroundPrefab[(int)(GroundPrefab.Length * Random.value)], transform.position, Quaternion.identity);
            timeTilSpawn = spawnTime;
        }
        timeTilSpawn -= Time.deltaTime;
    }
}
