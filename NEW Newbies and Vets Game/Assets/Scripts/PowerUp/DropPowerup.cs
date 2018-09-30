using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DropPowerup : MonoBehaviour {

	
	public GameObject[] powerups; //array of powerups to be added in editor
	public int enemyHealth = 100; // enemy health for testing purposes
	public float chanceToDropPowerup = 5f; //the percent chance that any given enemy will drop a powerup on death
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
		//checks for health to fall below zero, then rolls to see if a powerup drops.
		//if the powerup drops, uses a randomly selected one from the array. Then destorys the enemy
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
