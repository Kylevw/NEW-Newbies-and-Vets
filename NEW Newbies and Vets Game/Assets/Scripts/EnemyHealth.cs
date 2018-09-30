using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int enemyHealth = 100;
    public int damage = 25;

     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player projectile")
        {
            enemyHealth -= damage;
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
        if(enemyHealth <= 0)
        {
            
        }


	}
}
