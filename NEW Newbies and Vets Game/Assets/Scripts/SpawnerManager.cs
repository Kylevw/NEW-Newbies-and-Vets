using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour {
    public float timeTilFlySpawn;
    public float timeTilSwoopSpawn;
    public float timeTilGroundSpawn;
    public float flySpawnTime;
    public float swoopSpawnTime;
    public float groundSpawnTime;
    public GameObject[] groundSpawnerObjs;
    private GroundMonsterSpawner[] groundSpawners;
    public GameObject[] swoopingSpawnerObjs;
    private SwoopingMonsterSpawner[] swoopingSpawners;
    public GameObject[] flyingSpawnerObjs;
    private FlyingMonsterSpawner[] flyingSpawners;
    // Use this for initialization
    void Start () {
        groundSpawnerObjs = GameObject.FindGameObjectsWithTag("GroundSpawner");
        for (int i = 0; i < groundSpawnerObjs.Length; i++)
        {
            groundSpawners[i] = groundSpawnerObjs[i].AddComponent<GroundMonsterSpawner>();
        }
        flyingSpawnerObjs = GameObject.FindGameObjectsWithTag("FlyingSpawner");
        for (int i = 0; i < flyingSpawnerObjs.Length; i++)
        {
            flyingSpawners[i] = flyingSpawnerObjs[i].AddComponent<FlyingMonsterSpawner>();
        }
        swoopingSpawnerObjs = GameObject.FindGameObjectsWithTag("SwoopingSpawner");
        for (int i = 0; i < swoopingSpawnerObjs.Length; i++)
        {
            swoopingSpawners[i] = swoopingSpawnerObjs[i].AddComponent<SwoopingMonsterSpawner>();
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (timeTilFlySpawn<=0.0f){
            
            flyingSpawners[(int)(Random.value*flyingSpawners.Length)].Spawn();
            timeTilFlySpawn = flySpawnTime;
        }
        if (timeTilGroundSpawn <= 0.0f)
        {

            groundSpawners[(int)(Random.value * groundSpawners.Length)].Spawn();
            timeTilGroundSpawn = groundSpawnTime;
        }
        if (timeTilSwoopSpawn <= 0.0f)
        {

            swoopingSpawners[(int)(Random.value * swoopingSpawners.Length)].Spawn();
            timeTilSwoopSpawn = swoopSpawnTime;
        }
    }
}
