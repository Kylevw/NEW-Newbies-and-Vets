﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour {

    /*
     * This script controls all player properties like health, speed, jump height, ect.
     * It is modular so you can add what you need to it.
     * To use these variables, make sure you pass them to your script!
     * 
     * these values will be modified by powerups via the powerUp script
     */



        //the player variable stats
    public int health;
    public int moveSpeed;
    public int attack;
    public int jumpHeight;
    public float resTime;
    public int mana;

	public HealthBar healthBar;

	private void Start()
	{
		HealthSystem healthSystem = new HealthSystem(100);

		healthBar.Setup(healthSystem);
	}


}
