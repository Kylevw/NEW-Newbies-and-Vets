using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DropPowerup : MonoBehaviour {

	
	public GameObject[] powerups;
	public int enemyHealth = 100;
	public float chanceToDropPowerup = 5f; //the percent chance that any given enemy will drop a powerup on death
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
		
	if(enemyHealth <= 0){

		int whichPowerUp = Random.Range(0, powerups.Length + 1);
		float rand = Random.Range(1f, 101f);

		if(rand <= chanceToDropPowerup){
			Instantiate(powerups[whichPowerUp], this.transform.position, this.transform.rotation);
		}

		this.enabled = false;
	}
	
	}
}
