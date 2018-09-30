using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingMonsterSpawner : MonoBehaviour
{

    public GameObject[] FlyingPrefab;
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
            Instantiate(FlyingPrefab[(int)(FlyingPrefab.Length * Random.value)], transform.position, Quaternion.identity);
            timeTilSpawn = spawnTime;
        }
        timeTilSpawn -= Time.deltaTime;
    }
}
