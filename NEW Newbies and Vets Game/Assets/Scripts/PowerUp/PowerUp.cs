using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUp : MonoBehaviour {

    /*
    This is the archetype script for powerups, these should only be able to communicate with players
    This works in conjunction with the "PlayerProperties" script. This script updates values within PlayerProperties.
    PlayerProperties is held by an empty game object with tag "Stat Holder"

    */

   


    private void Awake()
    {
       
    }

    public bool healthIncrease;
    public int healthIncreaseAmt;

    public bool moveSpeedUp;
   public int moveSpeedUpAmt;

   public bool restTimeFaster;
   public float restTimeDecrease; //by a percentage amount

   public bool attackUp;
   public int attackIncrease;

    public bool jumpHigher;
    public int jumpIncrease;



    private void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject obj = GameObject.FindWithTag("Stat Holder");
        PlayerProperties playerProperties = obj.GetComponent<PlayerProperties>();

        if (healthIncrease)
        {
            playerProperties.health += healthIncreaseAmt;

        }

        if (moveSpeedUp)
        {
            playerProperties.moveSpeed += moveSpeedUpAmt;

        }

        if (restTimeFaster)
        {
            playerProperties.resTime = playerProperties.resTime * restTimeDecrease;
        }

        if (attackUp)
        {
            playerProperties.attack += attackIncrease;
        }

        if (jumpHigher)
        {
            playerProperties.jumpHeight += jumpIncrease;
        }

        Destroy(gameObject);
    }


   
}
